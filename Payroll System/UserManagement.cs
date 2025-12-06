using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            LoadUserTable();
            LoadUsernames(searchbox);
        }

        public static class dbConnector
        {
            private static readonly string connectionString =
                "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            // Admin-only navigation
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            home_btn_Click(sender, e); // same as Home
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }

        private void LoadUserTable()
        {
            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        l.user_id,
                        l.username,
                        CASE 
                            WHEN l.employee_id IS NOT NULL THEN 'Employee'
                            ELSE 'Admin'
                        END AS role,
                        ISNULL(uc.email, '—') AS email
                    FROM login l
                    LEFT JOIN UserContact uc ON l.user_id = uc.user_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                userAccounts.DataSource = dt;
                userAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                userAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                userAccounts.AllowUserToResizeColumns = false;
                userAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                userAccounts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void add_admin_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
        public void LoadUsernames(ComboBox searchbox)
        {
            string query = "SELECT user_id, username FROM login";

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    searchbox.DataSource = dt;
                    searchbox.DisplayMember = "username";   // What user sees
                    searchbox.ValueMember = "user_id";      // The actual value behind each item
                    searchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    searchbox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    searchbox.SelectedIndex = -1;
                    searchbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading usernames: " + ex.Message);
                }
            }
        }
    }
}