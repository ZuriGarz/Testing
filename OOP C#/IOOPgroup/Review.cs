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
    
    public partial class Review : Form
    {
        
        public static string Name;
        public static string Urgent;
        
        public Review()
        {
            InitializeComponent();
        }
        
        public Review(string n, string u)
        {
            InitializeComponent();
            Name = n;
            Urgent = u;
        }

        private void Review_Load(object sender, EventArgs e)
        {
            lblName.Text = Name+"'s Laptop Completion";
            MessageBox.Show(Urgent);
;           lblProb.Text = "Service : " +Technician.TechnicianCheck(Name) + " which are " + Urgent;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string Complete = "In Proggress";
            string Cheect1 = "1";
            lblcomplete1.Text = Complete;
            lblname1.Text = Name;
            if (Rdbtn1.Checked)
            {
                Cheect1 = "1";
            }

            else if (Rdbtn2.Checked)
            {
                Cheect1 = "2";
            }
            
            Technician obj2 = new Technician(Name, lblcomplete1.Text, textBox1.Text, dateTimePicker1.Text, Cheect1);
            MessageBox.Show(obj2.ReviewCompletion());
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
