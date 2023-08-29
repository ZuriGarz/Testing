using System;
using System.Windows.Forms;

namespace IOOPgroup
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            //hide form after button click
            loginpage obj1 = new loginpage(txtUsername.Text, txtPassword.Text);
            
            stat = obj1.login1();
            
            //if login failed
            if (stat != null)
            {
                //if login failed, show hidden login form
                //this.Show();
                MessageBox.Show(stat);
            }


            //clear textbox
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}