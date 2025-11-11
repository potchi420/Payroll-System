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
            Application.Exit();
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

        public void save_btn_Click(object sender, EventArgs e)
        {
            string firstName = first_name.Text.Trim();
            string lastName = last_name.Text.Trim();
            string contact = contact_no.Text.Trim();
            string address = Address.Text.Trim();
            string emailAddress = email.Text.Trim();
            decimal salary = Convert.ToDecimal(Salary.Text);
            object departmentID = department.SelectedValue;

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string add_emp = @"INSERT INTO employee (first_name, last_name, [Contact no.], address, department_id, salary, last_update, email) 
                                                VALUES (@FirstName, @LastName, @contact_no, @Address, @department_id, @Salary, @last_update, @email)";
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
                    cmd.ExecuteNonQuery();
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
                smtp.Credentials = new NetworkCredential("payrollsystemm@gmail.com", "qytn rqet tetq qtoj"); // login niyo to if itetest niyo to
                smtp.EnableSsl = true;
                smtp.Send(message);

                /* store login credentials in login table
                 * should fetch the employee_id of the newly added employee first tho 
                 * before inserting into login table
                using (SqlConnection connector = dbConnector.GetConnection())
                {
                    string add_emp = @"INSERT INTO login (username, password, [Contact no.], address, department_id, salary, last_update, email) 
                                                VALUES (@FirstName, @LastName, @contact_no, @Address, @department_id, @Salary, @last_update, @email)";
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
                        cmd.ExecuteNonQuery();
                    }
                }
                */


                MessageBox.Show("Employee details saved and email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee saved, but failed to send email: " + ex.Message);
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
    }
}
