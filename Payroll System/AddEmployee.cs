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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            load_departments(department);
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
            using (SqlConnection connector = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
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

            // Code to save the new employee details to the database
            using (SqlConnection connector = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
            {
                string add_emp = "INSERT INTO employee (first_name, last_name, [Contact no.], address, department_id, salary, last_update) " +
                                     "VALUES (@FirstName, @LastName, @contact_no, @Address, @department_id, @Salary, @last_update)";
                using (SqlCommand cmd = new SqlCommand(add_emp, connector))
                {
                    cmd.Parameters.AddWithValue("@FirstName", first_name.Text);
                    cmd.Parameters.AddWithValue("@LastName", last_name.Text);
                    cmd.Parameters.AddWithValue("@contact_no", contact_no.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.Parameters.AddWithValue("@department_id", department.SelectedValue);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(Salary.Text));
                    cmd.Parameters.AddWithValue("@last_update", DateTime.Now);

                    connector.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Employee details saved successfully!");
        }
    }
}
