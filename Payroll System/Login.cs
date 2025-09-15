using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnblogin_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            bool tr = cn.DataReceive(username.Text,password.Text);

            dashboard db= new dashboard();
            db.Show();
            this.Show();

        }
    }
}
