
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPgroup
{
    public partial class changeProf : Form
    {
        public static string useruser;
        public changeProf(string userini)
        {
            InitializeComponent();
            useruser = userini;
        }
        public changeProf()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show(useruser);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuRecep mmr = new mainMenuRecep();
            mmr.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = changeNameTXB.Text;
            string pass = changePassTXB.Text;
            changeProfile changeProfi = new changeProfile();
            changeProfi.profile(name, pass, useruser);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeNameTXB.Text = " ";
            changePassTXB.Text = " ";
        }
    }
}
