using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

    namespace Payroll_System
    {
    public partial class EmailVerification : Form
    {
        public string PendingUsername { get; set; }
        public string PendingPassword { get; set; }
        private AccountManagements parentForm;

        public EmailVerification(AccountManagements parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.Load += EmailVerification_Load;
            StartOtpTimer();
            timerOTP.Tick += timerOtp_Tick;

            //sa textbox to. WAG GALAWIN
            for (int i = 1; i <= 6; i++)
            {
                TextBox tb = this.Controls["textBox" + i] as TextBox;
                if (tb != null)
                {
                    tb.MaxLength = 1;
                    tb.KeyUp += OtpTextBox_KeyUp;
                }
            }
        }


        int remainingSeconds = 120; //2 minutes lang
        private string generatedOtp;
        private AccountManagements accountManagements;

        // OTP messagebox and timerstart sa load ng form
        private void StartOtpTimer()
        {
            remainingSeconds = 120;
            lblTimer.Text = "Code expires in 02:00";
            timerOTP.Start();
        }

        private void timerOtp_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            TimeSpan ts = TimeSpan.FromSeconds(remainingSeconds);
            lblTimer.Text = $"Code expires in {ts.Minutes:D2}:{ts.Seconds:D2}";

            if (remainingSeconds <= 0)
            {
                timerOTP.Stop();
                lblTimer.Text = "Code expired.";
                verifybtn.Enabled = false;
            }
        }
        private void OtpTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox current = sender as TextBox;

            if (current.Text.Length == 1 && e.KeyCode != Keys.Back)
            {
                // Move to next textbox
                this.SelectNextControl(current, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Back && current.Text.Length == 0)
            {
                // Move to previous textbox
                this.SelectNextControl(current, false, true, true, true);
            }
        }

        //email otp sending systme and button functions
        private void EmailVerification_Load(object sender, EventArgs e)
        {
            string recipientEmail = GetUserEmail();
            if (!string.IsNullOrEmpty(recipientEmail))
            {
                SendOtpEmail(recipientEmail);
            }
            else
            {
                MessageBox.Show("No email address found for this account.");
                verifybtn.Enabled = false;
            }
        }

        private string GetUserEmail()
        {
            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();

                string query;
                SqlCommand cmd;

                if (Connector.SessionData.EmployeeID.HasValue)
                {
                    query = "SELECT email FROM Employee WHERE employee_id = @empId";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@empId", Connector.SessionData.EmployeeID.Value);
                }
                else
                {
                    query = "SELECT email FROM UserContact WHERE user_id = @userId";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", Connector.SessionData.UserID);
                }

                object result = cmd.ExecuteScalar();
                return result == null ? string.Empty : result.ToString();
            }
        }

        private void GenerateOtp()
        {
            Random rnd = new Random();
            generatedOtp = rnd.Next(100000, 999999).ToString(); // 6-digit OTP
        }

        private void SendOtpEmail(string recipientEmail)
        {
            GenerateOtp();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("payrollsystemm@gmail.com");
            mail.To.Add(recipientEmail);
            mail.Subject = "Your OTP Code";
            mail.Body = $"Your verification code is {generatedOtp}. It will expire in 2 minutes.";

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;     // force custom credentials
                smtp.Credentials = new NetworkCredential(
                    "payrollsystemm@gmail.com",
                    "vgit lcvy muai knjk"               // Gmail App Password
                );
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

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

        private void verifybtn_Click(object sender, EventArgs e)
        {
            string enteredOtp = textBox1.Text + textBox2.Text + textBox3.Text +
                                textBox4.Text + textBox5.Text + textBox6.Text;

            if (enteredOtp == generatedOtp && remainingSeconds > 0)
            {
                ApplyChanges(); // update username/password in DB
            }
            else
            {
                MessageBox.Show("Invalid or expired OTP.");
            }
        }

        private void ApplyChanges()
        {
            using (SqlConnection conn = dbConnector.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Login SET username=@newUsername, password=@newPassword WHERE user_id=@userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newUsername", PendingUsername);
                    cmd.Parameters.AddWithValue("@newPassword", PendingPassword);
                    cmd.Parameters.AddWithValue("@userId", Connector.SessionData.UserID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Account details updated successfully!");

            parentForm.cur_username_value.Text = string.Empty;
            parentForm.cur_password_value.Text = string.Empty;
            parentForm.new_username_value.Text = string.Empty;
            parentForm.new_password_value.Text = string.Empty;

            this.Close();
        }

        private void resendbtn_Click(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                MessageBox.Show("You can only resend the code once the timer expires.");
                return;
            }


            StartOtpTimer();
            verifybtn.Enabled = true;


            string recipientEmail = GetUserEmail();
            if (!string.IsNullOrEmpty(recipientEmail))
            {
                SendOtpEmail(recipientEmail);
                MessageBox.Show("A new OTP has been sent to your email.");
            }
            else
            {
                MessageBox.Show("No email address found.");
            }
        }
    }
}
