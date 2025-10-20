using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Payroll_System
{
    public partial class Employeedashboard : Form
    {
        private string query;

        public Employeedashboard()
        {
            InitializeComponent();
            LoadInitialEmployees();
            SetupGridColumns();
            LoadEmployeeNames(searchbox);
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

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Show();
            this.Hide();
        }


        private void LoadInitialEmployees()
        {
            string query = "SELECT TOP 50 * FROM employee";
            dataGridViewEmployees.DataSource = GetEmployees(query);
            // Auto-size columns to fit content
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewEmployees.AllowUserToResizeColumns = false;
            dataGridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetupGridColumns()
        {
            // Add Document Button Column
            DataGridViewButtonColumn docButton = new DataGridViewButtonColumn();
            docButton.Name = "Document";
            docButton.HeaderText = "Document";
            docButton.Text = "📄";
            docButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(docButton);

            // Add Edit Button Column
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "edit_employee_btn";
            editButton.HeaderText = "Edit";
            editButton.Text = "✏️";
            editButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(editButton);

            // Add Remove Button Column
            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "remove_employee_btn";
            removeButton.HeaderText = "Remove";
            removeButton.Text = "🗑️";
            removeButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(removeButton);

            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
        }

        /*
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = $"SELECT ID, Name, Department, Email FROM Employees WHERE Name LIKE '%{keyword}%'";
            dataGridViewEmployees.DataSource = GetEmployees(query);
        }
        */

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int empID = Convert.ToInt32(dataGridViewEmployees.Rows[e.RowIndex].Cells["employee_id"].Value);
                string column = dataGridViewEmployees.Columns[e.ColumnIndex].Name;

                if (column == "Document")
                {
                    MessageBox.Show($"Open document for ");

                }
                else if (column == "remove_employee_btn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        using (SqlConnection connector = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
                        { 
                            string deleteQuery = "DELETE FROM employee WHERE employee_id = @empID";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connector))
                            {
                                cmd.Parameters.AddWithValue("@empID", empID);
                                connector.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Employee details deleted successfully!");
                        reloadForm();
                    }
                }
                else if (column == "edit_employee_btn")
                {
                    MessageBox.Show($"Edit employee ");
                }
            }
        }

        private DataTable GetEmployees(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connector = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void LoadEmployeeNames(ComboBox searchbox)
        {
            string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName FROM employee";

            using (SqlConnection connector = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    searchbox.DataSource = dt;
                    searchbox.DisplayMember = "FullName";   // What user sees
                    searchbox.ValueMember = "employee_id";  // The actual value behind each item
                    searchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    searchbox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    searchbox.SelectedIndex = -1;
                    searchbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }
        }
        public void reloadForm()
        {
            LoadInitialEmployees();
        }
    }
}