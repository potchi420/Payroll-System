using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class Login : Form
    {


        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        private void button1_Click_1(object sender, EventArgs e)
        {

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
