

using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class ResetPassword : Form
    {
        private string userEmail;

        public ResetPassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private int GetUserIdByEmail(string email)
        {
            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT TOP 1 l.user_id
                FROM login l
                    LEFT JOIN Employee e ON l.employee_id = e.employee_id
                    LEFT JOIN UserContact uc ON l.user_id = uc.user_id
                WHERE 
                    (e.email = @email AND e.is_active = 1)
                    OR (uc.email = @email)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    object result = cmd.ExecuteScalar();
                    return result == null ? -1 : Convert.ToInt32(result);
                }
            }
        }
        private void reset_btn_Click(object sender, EventArgs e)
        {
            string newPassword = newPass.Text.Trim();
            string confirmPassword = confirmPass.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = GetUserIdByEmail(userEmail);
            if (userId == -1)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();
                string query = "UPDATE login SET password = @password WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@password", newPassword); 
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
