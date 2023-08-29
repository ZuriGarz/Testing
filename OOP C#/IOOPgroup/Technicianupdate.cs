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
    public partial class UpdateTechnician : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static string TechName;
        public UpdateTechnician()
        {
            InitializeComponent();
        }
        public UpdateTechnician(string n)
        {
            InitializeComponent();
            TechName = n;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameChange = nameBox.Text.ToString();
            string Password = textBox1.Text.ToString();
            MessageBox.Show(TechName);
            Technician obj1 = new Technician(nameBox.Text, textBox1.Text, TechName);
            MessageBox.Show(obj1.UpdateTechnicianAcc());
            this.Close();

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTechnician_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
