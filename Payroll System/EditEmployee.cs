using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
                            contact_no.Text = reader["Contact no."].ToString();
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

        public void save_btn_Click(object sender, EventArgs e)
        {

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

    }
}
