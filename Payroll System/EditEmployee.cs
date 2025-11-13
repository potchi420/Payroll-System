using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class EditEmployee : Form
    {
        int empID;
        public EditEmployee(int empID)
        {
            InitializeComponent();
            this.empID = empID;
            LoadDepartments();
            LoadEmployeeData();
            focus_remover();
        }

        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        public void LoadEmployeeData()
        {
            string query = "SELECT * FROM employee WHERE employee_id = @employee_id";
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, connector))
                {
                    cmd.Parameters.AddWithValue("@employee_id", empID);
                    connector.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have textboxes named txtName, txtDepartment, txtEmail
                            first_name.Text = reader["first_name"].ToString();
                            last_name.Text = reader["last_name"].ToString();
                            contact_no.Text = reader["contact_number"].ToString();
                            Salary.Text = reader["salary"].ToString();
                            Address.Text = reader["address"].ToString();
                            department.SelectedValue = reader["department_id"];
                        }
                    }
                }
            }
        }
        private void LoadDepartments()
        {
            string query = "SELECT department_id, department_name FROM department";
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connector))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    department.DataSource = dt;
                    department.DisplayMember = "department_name";
                    department.ValueMember = "department_id";
                }
            }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            Employeedashboard employeedashboard = new Employeedashboard();
            employeedashboard.Show();
            this.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateEmployeeBeforeUpdate()
        {
            string firstName = first_name.Text.Trim();
            string lastName = last_name.Text.Trim();
            string contact = contact_no.Text.Trim();
            string address = Address.Text.Trim();
            string salaryText = Salary.Text.Trim();
            string emailText = email.Text.Trim();
            object departmentID = department.SelectedValue;

            // 1️⃣ Required field check
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(salaryText) ||
                string.IsNullOrWhiteSpace(emailText) ||
                departmentID == null)
            {
                MessageBox.Show("Please fill in all required fields before saving.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // 2️⃣ First & last name validation (letters only)
            if (!firstName.All(char.IsLetter))
            {
                MessageBox.Show("First name should contain letters only.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                first_name.Focus();
                return false;
            }

            if (!lastName.All(char.IsLetter))
            {
                MessageBox.Show("Last name should contain letters only.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                last_name.Focus();
                return false;
            }

            // 3️⃣ Contact validation (exactly 11 digits)
            if (contact.Length != 11 || !contact.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must be exactly 11 digits and contain only numbers.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                contact_no.Focus();
                return false;
            }

            // Optional: must start with "09"
            if (!contact.StartsWith("09"))
            {
                MessageBox.Show("Contact number must start with '09'.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                contact_no.Focus();
                return false;
            }

            // 4️⃣ Salary validation
            if (!decimal.TryParse(salaryText, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Salary must be a positive number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                Salary.Focus();
                return false;
            }

            // 5️⃣ Email validation (simple pattern)
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailText, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                email.Focus();
                return false;
            }

            // ✅ Passed all checks
            return true;
        }

        public void save_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeBeforeUpdate())
            {
                // Stop here if validation fails
                return;
            }

            // Code to save the new employee details to the database
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string update_emp = "UPDATE employee SET " +
                                    "first_name = @FirstName, " +
                                    "last_name = @LastName, " +
                                    "[Contact no.] = @contact_no, " +
                                    "address = @Address, " +
                                    "department_id = @department_id, " +
                                    "salary = @Salary, " +
                                    "last_update = @last_update " +
                                    "email = @email " +
                                    "WHERE employee_id = @employee_id";
                using (SqlCommand cmd = new SqlCommand(update_emp, connector))
                {
                    cmd.Parameters.AddWithValue("@FirstName", first_name.Text);
                    cmd.Parameters.AddWithValue("@LastName", last_name.Text);
                    cmd.Parameters.AddWithValue("@contact_no", contact_no.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.Parameters.AddWithValue("@department_id", department.SelectedValue);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(Salary.Text));
                    cmd.Parameters.AddWithValue("@last_update", DateTime.Now);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@employee_id", empID);

                    connector.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Employee details edited successfully!");
            Employeedashboard employeedashboard = new Employeedashboard();
            employeedashboard.Show();
            this.Show();
            this.Hide();
        }
        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }

        private void first_name_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void last_name_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void contact_no_TextChanged(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                return;
            }

            // Limit to 11 digits
            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void Salary_TextChanged(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow control keys (like Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only digits and one dot
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block invalid input
                return;
            }

            // Allow only one dot (prevent typing multiple decimals)
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
