using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            load_departments(department);
            focus_remover();
        }

        //change the connection string as per your sql server
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Employeedashboard ed = new Employeedashboard();
            ed.Show();
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
            Logout.Execute(this);
        }

        private void load_departments(ComboBox departments)
        {
            string query = "SELECT department_id, department_name FROM department";
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    departments.DataSource = dt;
                    departments.DisplayMember = "department_name";   // What user sees
                    departments.ValueMember = "department_id";  // The actual value behind each item
                    departments.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    departments.AutoCompleteSource = AutoCompleteSource.ListItems;
                    departments.SelectedIndex = -1;
                    departments.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }
        }


        private bool ValidateEmployeeInput()
        {
            string firstName = first_name.Text.Trim();
            string lastName = last_name.Text.Trim();
            string contact = contact_no.Text.Trim();
            string address = Address.Text.Trim();
            string emailAddress = email.Text.Trim();
            string salaryText = Salary.Text.Trim();
            object departmentID = department.SelectedValue;

            // 1️⃣ Check empty fields
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(emailAddress) ||
                string.IsNullOrWhiteSpace(salaryText) ||
                departmentID == null)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // 2️⃣ First and last name validation
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

            // 3️⃣ Contact number validation
            if (contact.Length != 11 || !contact.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must be exactly 11 digits.",
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailAddress, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                email.Focus();
                return false;
            }

            // ✅ Everything passed
            return true;
        }

        public void save_btn_Click(object sender, EventArgs e)
        {

            if (!ValidateEmployeeInput())
            {
                // Stop if validation failed
                return;
            }

            string firstName = first_name.Text.Trim();
            string lastName = last_name.Text.Trim();
            string contact = contact_no.Text.Trim();
            string address = Address.Text.Trim();
            string emailAddress = email.Text.Trim();
            decimal salary = Convert.ToDecimal(Salary.Text);
            object departmentID = department.SelectedValue;
            int newEmployeeID = 0;

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string add_emp = @"INSERT INTO employee 
                    (first_name, last_name, [Contact no.], address, department_id, salary, last_update, email, is_active)
                    VALUES 
                    (@FirstName, @LastName, @contact_no, @Address, @department_id, @Salary, @last_update, @email, 1);
                    SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(add_emp, connector))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@contact_no", contact);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@department_id", departmentID);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@last_update", DateTime.Now);
                    cmd.Parameters.AddWithValue("@email", emailAddress);

                    connector.Open();
                    object result = cmd.ExecuteScalar();
                    newEmployeeID = Convert.ToInt32(result);


                }
            }


            try
            {
                string username = (firstName + lastName).ToLower();
                string password = "password1234";

                MailMessage message = new MailMessage();
                message.From = new MailAddress("payrollsytemm@gmail.com");
                message.To.Add(emailAddress);
                message.Subject = "Your Payroll System Account";
                message.Body = $"Hello {firstName},\n\nYour account has been created.\n\nUsername: {username}\nPassword: {password}\n\nPlease change your password after logging in.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("payrollsystemm@gmail.com", "vgit lcvy muai knjk"); // login niyo to if itetest niyo to
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Employee details saved and email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee saved, but failed to send email: " + ex.Message);
            }

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string add_login = @"INSERT INTO login (username, password, employee_id)
                             VALUES (@username, @password, @employee_id)";

                using (SqlCommand cmd = new SqlCommand(add_login, connector))
                {
                    cmd.Parameters.AddWithValue("@username", firstName.ToLower() + lastName.ToLower());
                    cmd.Parameters.AddWithValue("@password", "password1234");
                    cmd.Parameters.AddWithValue("@employee_id", newEmployeeID);

                    connector.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
