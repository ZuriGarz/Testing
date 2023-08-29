using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPgroup
{
    public partial class ViewDescription : Form
    {
        public static string Name;
        
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public ViewDescription()
        {
            InitializeComponent();
        }

        public ViewDescription(string n)
        {
            InitializeComponent();
            Name = n;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewDescription_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Data where Name='" + Name + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtLaptopType.Text = rd.GetString(3);
                txtServiceType.Text = rd.GetString(4);
                txtDate.Text = rd.GetDateTime(8).ToString("dd/MM/yyyy"); //Date - month - Year
                txtDescription.Text = rd.GetString(10);
            }
            con.Close();
        }
    }
}

