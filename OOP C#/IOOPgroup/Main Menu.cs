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
    public partial class mainMenuRecep : Form
    {
        public static string useruser;
        public mainMenuRecep()
        {
            InitializeComponent();
        }
        public mainMenuRecep(string user1)
        {
            useruser = user1;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuRecep_Load(object sender, EventArgs e)
        {

        }

        private void buttonCus_Click(object sender, EventArgs e)
        {
            registerCus rc = new registerCus();
            rc.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cusPayment cp = new cusPayment();
            cp.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeProf cpf = new changeProf(useruser);
            cpf.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
