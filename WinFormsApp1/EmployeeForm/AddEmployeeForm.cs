using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class AddEmployeeForm : Form
    {
        private WinFormDbEntities dbContext = new WinFormDbEntities();
        private ErrorProvider errorProvider;

        public AddEmployeeForm()
        {
            InitializeComponent();
            LoadJobTitles(); // Load job titles into the combo box
            jobTitleInput.DropDownStyle = ComboBoxStyle.DropDownList; // Set the DropDownStyle property to DropDownList to ensure users are only able to SELECT not WRITE
            errorProvider = new ErrorProvider();
        }

        private void LoadJobTitles()
        {
            jobTitleInput.DataSource = dbContext.JobTitles.ToList();
            jobTitleInput.DisplayMember = "Title";
            jobTitleInput.ValueMember = "JobTitleID";
        }

        private void ClearForm()
        {
            // Clear all input fields
            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            mobileNoInput.Text = string.Empty;
            jobTitleInput.SelectedIndex = -1;
            salaryInput.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Clear previous error provider messages
            errorProvider.Clear();

            // First Name required
            if (string.IsNullOrWhiteSpace(firstNameInput.Text))
            {
                errorProvider.SetError(firstNameInput, "First Name is required");
                isValid = false;
            }

            // Last Name required
            if (string.IsNullOrWhiteSpace(lastNameInput.Text))
            {
                errorProvider.SetError(lastNameInput, "Last Name is required");
                isValid = false;
            }

            // Mobile No required
            if (string.IsNullOrWhiteSpace(mobileNoInput.Text))
            {
                errorProvider.SetError(mobileNoInput, "Mobile number is required");
                isValid = false;
            }
            else if (!Regex.IsMatch(mobileNoInput.Text, @"^\d+$"))
            {
                // Mobile No should have only digits
                errorProvider.SetError(mobileNoInput, "Input field should have only digits");
                isValid = false;
            }
            else if (mobileNoInput.Text.Length != 10)
            {
                // Mobile No should have exactly 10 digits
                errorProvider.SetError(mobileNoInput, "Input field must have exactly 10 digits");
                isValid = false;
            }

            // Salary required
            if (string.IsNullOrWhiteSpace(salaryInput.Text))
            {
                errorProvider.SetError(salaryInput, "Salary is required");
                isValid = false;
            }
            else if (!decimal.TryParse(salaryInput.Text, out _))
            {
                // Salary must be a numeric value
                errorProvider.SetError(salaryInput, "Salary must be a numeric value");
                isValid = false;
            }
            else if (decimal.Parse(salaryInput.Text) < 0)
            {
                // Salary must be a non-negative value
                errorProvider.SetError(salaryInput, "Salary must be a non-negative value");
                isValid = false;
            }

            // Display the error messages in a visible tooltip
            if (!isValid)
            {
                MessageBox.Show("Please correct the validation errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            // Validate input
            if (ValidateForm())
            {
                // Create an Employee object with the form data
                Employee employee = new Employee
                {
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    MobileNo = mobileNoInput.Text,
                    JobTitleID = Convert.ToInt32(jobTitleInput.SelectedValue),
                    Salary = Convert.ToDecimal(salaryInput.Text)
                };

                // Save the employee data
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                MessageBox.Show("Employee added successfully!");
                DisplayAllEmployees();
                ClearForm(); // Clear the form after submission
            }
        }

        private void DisplayAllEmployees()
        {
            // Fetch all employees from the database
            var employees = dbContext.Employees.ToList();

            // Create a string to store the employee data
            string allData = "Employee Data:\n";

            // Append each employee's information to the string
            foreach (var emp in employees)
            {
                allData += $"ID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, MobileNo: {emp.MobileNo}, JobTitle: {emp.JobTitle?.Title}, Salary: {emp.Salary}\n";
            }

            // Show the data in a message box
            MessageBox.Show(allData, "Employee Data");
        }
    }
}
