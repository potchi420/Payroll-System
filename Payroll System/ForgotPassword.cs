using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private string generatedOtp = string.Empty;
        private bool otpSent = false;
        private string userEmail = string.Empty;


        private void send_code_btn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var addr = new MailAddress(email);
                if (addr.Address != email)
                    throw new FormatException();
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EmailExists(email))
            {
                MessageBox.Show("This email is not registered in the system.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userEmail = email;
            SendOtpEmail(email);
            otpSent = true;
            verify_btn.Enabled = true;

            MessageBox.Show("Verification code sent to your email.", "Code Sent",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            if (!otpSent)
            {
                MessageBox.Show("Please request a verification code first.", "No Code Sent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string enteredCode = txtCode.Text.Trim();

            if (string.IsNullOrEmpty(enteredCode))
            {
                MessageBox.Show("Please enter the verification code.", "Missing Code",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredCode != generatedOtp)
            {
                MessageBox.Show("Incorrect verification code.", "Invalid Code",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Verification successful. You may now reset your password.", "Verified",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetPassword resetForm = new ResetPassword(userEmail);
            resetForm.Show();
            this.Hide();
        }

        private void SendOtpEmail(string recipientEmail)
        {
            GenerateOtp();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("payrollsystemm@gmail.com");
            mail.To.Add(recipientEmail);
            mail.Subject = "Your OTP Code";
            mail.Body = $"Your verification code is {generatedOtp}.";

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(
                    "payrollsystemm@gmail.com",
                    "vgit lcvy muai knjk"
                );

                try
                {
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send OTP: " + ex.Message);
                }
            }
        }

        private void GenerateOtp()
        {
            Random rnd = new Random();
            generatedOtp = rnd.Next(100000, 999999).ToString();
        }

        private bool EmailExists(string email)
        {
            using (SqlConnection conn = AccountManagements.dbConnector.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employee WHERE email = @email AND is_active = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}