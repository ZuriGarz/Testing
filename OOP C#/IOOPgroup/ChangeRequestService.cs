using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOPgroup
{
    public partial class ChangeRequestService : Form
    {


        public static string Name1;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public ChangeRequestService()
        {
            InitializeComponent();
        }
        public ChangeRequestService(string Name)
        {
            InitializeComponent();
            Name1 = Name;
        }

        private void txtChangeLaptop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChangeService_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChangeDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = txtChangeService.Text;
            string des = txtChangeDescription.Text;
            string cl = txtChangeLaptop.Text;


            changerequest obj1 = new changerequest(Name1);
            MessageBox.Show(obj1.UpdateProfile(cs, des, cl));
        }

        private void ChangeRequestService_Load(object sender, EventArgs e)
        {

        }
    }
}
