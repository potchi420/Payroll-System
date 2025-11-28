using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class AccountManagements : Form
    {
        public AccountManagements()
        {
            InitializeComponent();
        }

        bool isEmployee = Connector.SessionData.EmployeeID.HasValue;

        //change the connection string as per your sql server
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private bool ValidateCurrentCredentials(string username, string password)
        {
            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Login WHERE user_id = @userId AND username = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", Connector.SessionData.UserID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int matchCount = (int)cmd.ExecuteScalar();
                    return matchCount == 1;
                }
            }
        }

        private void home_btn_Click_1(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string curUsername = cur_username_value.Text.Trim();
            string curPassword = cur_password_value.Text.Trim();
            string newUsername = new_username_value.Text.Trim();
            string newPassword = new_password_value.Text.Trim();

            if (string.IsNullOrEmpty(curUsername) || string.IsNullOrEmpty(curPassword))
            {
                MessageBox.Show("Please enter your current username and password.");
                return;
            }

            if (!ValidateCurrentCredentials(curUsername, curPassword))
            {
                MessageBox.Show("Invalid current username or password.");
                return;
            }

            EmailVerification ev = new EmailVerification(this);
            ev.PendingUsername = newUsername;
            ev.PendingPassword = newPassword;
            ev.ShowDialog();
        }
    }
}
