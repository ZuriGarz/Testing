using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace IOOPgroup
{
    public partial class Frm_serviceReport : Form
    {
        public Frm_serviceReport()
        {
            InitializeComponent();
        }

        
        private void btn_viewservice_Click(object sender, EventArgs e)
        {
            //create object array to store data from database
            ArrayList name = new ArrayList();
            //call obj method to get report
            name = ViewData.ViewReportName(textBox1.Text);
            //using loop store data into array
            foreach (var item in name)
                lstBox_service.Items.Add(item);
           

            ArrayList service = new ArrayList();
            service = ViewData.ViewReportService(textBox1.Text);
            foreach (var item in service)
                lstboxservice.Items.Add(item);

            ArrayList Urgenc = new ArrayList();
            Urgenc = ViewData.ViewReportUrgency(textBox1.Text);
            foreach (var item in Urgenc)
                lstboxurgen.Items.Add(item);

            ArrayList complete = new ArrayList();
            complete = ViewData.ViewReportCompletion(textBox1.Text);
            foreach (var item in complete)
                lstboxcomplete.Items.Add(item);

            if (lstboxservice.Items.Count == 0 && lstboxurgen.Items.Count == 0 && lstboxcomplete.Items.Count == 0)
                MessageBox.Show("there's no requested service in month " + textBox1.Text);
            textBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lstboxurgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_serviceReport_Load(object sender, EventArgs e)
        {
            //disable button at form load
            btn_viewservice.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //enable button after user input
            if (textBox1.Text != null)
                btn_viewservice.Enabled = true;
        }

        //method from microsoft forum to only input number in textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows backspace key
            if (e.KeyChar != '\b')
            {
                //allows just number keys
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            string a = "";
            this.Hide();
            Frm_Main_admin ma = new Frm_Main_admin(a);
            ma.ShowDialog();
            this.Close();
        }
    }
}
