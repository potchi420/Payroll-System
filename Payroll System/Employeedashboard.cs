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
            employeeEntriesCount();
            dataGridViewEmployees.CellMouseMove += dataGridViewEmployees_CellMouseMove;
            searchbox.KeyDown += searchbox_KeyDown;
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

                    // this has an error where you're not able to delete an employee if the employee has a payslip record
                    // a simple fix for this is to delete the payslip record too
                    // but i dont think deleting a payslip record is good practice for a payroll system
                    // for that should we add like a boolean "is_active" column in the db for this??
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connector = dbConnector.GetConnection())
                        {
                            string deleteLogin = "DELETE FROM login WHERE employee_id = @empID";
                            using (SqlCommand cmd = new SqlCommand(deleteLogin, connector))
                            {
                                cmd.Parameters.AddWithValue("@empID", empID);
                                connector.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        using (SqlConnection connector = dbConnector.GetConnection())
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
                    EditEmployee editEmployee = new EditEmployee(empID);
                    editEmployee.Show();
                    this.Show();
                    this.Hide();
                }
            }
        }

        private DataTable GetEmployees(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void LoadEmployeeNames(ComboBox searchbox)
        {
            string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName FROM employee";

            using (SqlConnection connector = dbConnector.GetConnection())
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
        private void dataGridViewEmployees_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewEmployees.Columns[e.ColumnIndex].Name;

                if (columnName == "edit_employee_btn" || columnName == "remove_employee_btn")
                {
                    dataGridViewEmployees.Cursor = Cursors.Hand;
                }
                else
                {
                    dataGridViewEmployees.Cursor = Cursors.Default;
                }
            }
            else
            {
                dataGridViewEmployees.Cursor = Cursors.Default;
            }
        }
        public void reloadForm()
        {
            LoadInitialEmployees();
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedName = searchbox.Text.Trim().ToLower();
                dataGridViewEmployees.ClearSelection();

                foreach (DataGridViewRow row in dataGridViewEmployees.Rows)
                {
                    if (row.Cells["first_name"].Value != null && row.Cells["last_name"].Value != null)
                    {
                        string fullName = (row.Cells["first_name"].Value.ToString() + " " + row.Cells["last_name"].Value.ToString()).ToLower();

                        if (fullName == selectedName)
                        {
                            row.Selected = true;
                            dataGridViewEmployees.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }

                e.Handled = true;
            }
        }

        public void employeeEntriesCount() 
        { 
            string query = "SELECT COUNT(*) FROM employee";
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, connector))
                {
                    connector.Open();
                    int count = (int)cmd.ExecuteScalar();
                    employee_entries.Text = "Showing " + count.ToString() + " Entries";
                }
            }
        }
    }
}