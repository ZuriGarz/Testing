using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOPgroup
{
    public partial class UpdateProfile : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string name;
        public UpdateProfile()
        {
            InitializeComponent();
        }

        public UpdateProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string status = "Failed";
            if (!string.IsNullOrEmpty(txtName.Text))
            {

                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    
                    SqlCommand cmd = new SqlCommand("update Data set Name='" + txtName.Text + "', Password='" + txtPassword.Text + "'  where Name='" + name + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed";
                    
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("update Data set Name='" + txtName.Text + "' where Name='" + name + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed";
                    
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    
                    SqlCommand cmd = new SqlCommand("update Data set Password='" + txtPassword.Text + "' where Name='" + name + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed";
                    
                }
                else
                {
                    status = "Failed";
                }
            }
            con.Close();
            MessageBox.Show(status);
            this.Close();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
