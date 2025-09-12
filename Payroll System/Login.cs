using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class Login : Form
    {


        SqlConnections con = new SqlConnections("Data Source=COI-LAB8-20\\SQLEXPRESS;Initial Catalog=db_payroll;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlCommand com;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            con.Open();
            com = new SqlCommand("INSERT into StudentInfo VALUES(@Username,@Password,)", con);
            com.Parameters.AddWithValue("@StudentNumber", (username.Text));
            com.Parameters.AddWithValue("@Firstname", (password.Text));
            com.ExecuteNonQuery();
            con.Close();
            */
        }


        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
