namespace EmployeeForm
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.mobileNo = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.mobileNoInput = new System.Windows.Forms.TextBox();
            this.salaryInput = new System.Windows.Forms.TextBox();
            this.jobTitleInput = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(140, 49);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(140, 92);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSize = true;
            this.mobileNo.Location = new System.Drawing.Point(140, 135);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(55, 13);
            this.mobileNo.TabIndex = 2;
            this.mobileNo.Text = "Mobile No";
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(140, 184);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(47, 13);
            this.jobTitle.TabIndex = 3;
            this.jobTitle.Text = "Job Title";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(140, 237);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(36, 13);
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(305, 42);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(190, 20);
            this.firstNameInput.TabIndex = 5;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(305, 85);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(190, 20);
            this.lastNameInput.TabIndex = 6;
            // 
            // mobileNoInput
            // 
            this.mobileNoInput.Location = new System.Drawing.Point(305, 128);
            this.mobileNoInput.Name = "mobileNoInput";
            this.mobileNoInput.Size = new System.Drawing.Size(190, 20);
            this.mobileNoInput.TabIndex = 7;
            // 
            // salaryInput
            // 
            this.salaryInput.Location = new System.Drawing.Point(305, 230);
            this.salaryInput.Name = "salaryInput";
            this.salaryInput.Size = new System.Drawing.Size(190, 20);
            this.salaryInput.TabIndex = 9;
            // 
            // jobTitleInput
            // 
            this.jobTitleInput.FormattingEnabled = true;
            this.jobTitleInput.Location = new System.Drawing.Point(305, 176);
            this.jobTitleInput.Name = "jobTitleInput";
            this.jobTitleInput.Size = new System.Drawing.Size(190, 21);
            this.jobTitleInput.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(305, 308);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.jobTitleInput);
            this.Controls.Add(this.salaryInput);
            this.Controls.Add(this.mobileNoInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.mobileNo);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label mobileNo;
        private System.Windows.Forms.Label jobTitle;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox mobileNoInput;
        private System.Windows.Forms.TextBox salaryInput;
        private System.Windows.Forms.ComboBox jobTitleInput;
        private System.Windows.Forms.Button submit;
    }
}