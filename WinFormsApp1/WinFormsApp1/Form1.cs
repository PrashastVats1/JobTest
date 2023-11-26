using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-H3OMMTNN\\SQLEXPRESS;Initial Catalog=WinFormDb;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Employee (FirstName, LastName, MobileNo, JobTitle, Salary) " +
                                     "VALUES (@FirstName, @LastName, @MobileNo, @JobTitle, @Salary)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    command.Parameters.AddWithValue("@LastName", textBox2.Text);
                    command.Parameters.AddWithValue("@MobileNo", textBox3.Text);
                    command.Parameters.AddWithValue("@JobTitle", textBox4.Text);
                    command.Parameters.AddWithValue("@Salary", decimal.Parse(textBox5.Text));

                    command.ExecuteNonQuery();
                }

                // Retrieve all data and display it
                string selectQuery = "SELECT * FROM Employee";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        string allData = "Employee Data:\n";
                        while (reader.Read())
                        {
                            allData += $"ID: {reader["EmployeeID"]}, FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}, MobileNo: {reader["MobileNo"]}, JobTitle: {reader["JobTitle"]}, Salary: {reader["Salary"]}\n";
                        }

                        // Show the data in a message box
                        MessageBox.Show(allData, "Employee Data");
                    }
                }

                connection.Close();
            }

            MessageBox.Show("Data inserted successfully!");
            this.Close();
        }
    }
}
