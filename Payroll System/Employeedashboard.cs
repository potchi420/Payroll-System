using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class Employeedashboard : Form
    {
        public Employeedashboard()
        {
            InitializeComponent();
            LoadInitialEmployees();
            SetupGridColumns();
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

            // Add Action Button Column
            DataGridViewButtonColumn actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = "Details";
            actionButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(actionButton);

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
                string name = dataGridViewEmployees.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string column = dataGridViewEmployees.Columns[e.ColumnIndex].Name;

                if (column == "Document")
                {
                    MessageBox.Show($"Open document for {name}");
                    // Add logic to open document
                }
                else if (column == "Action")
                {
                    MessageBox.Show($"Show details for {name}");
                    // Add logic to show employee details
                }
            }
        }

        private DataTable GetEmployees(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


    }
}