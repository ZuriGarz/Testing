
using System;
using System.Collections;
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
    public partial class cusPayment : Form
    {
        public cusPayment()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            receiptRTB.Text = string.Empty;
            total_txb.Text = string.Empty;
            mainMenuRecep mmr = new mainMenuRecep();
            this.Close();
            mmr.Show();
            Visible = false;
        }

        private void chooseCustCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            total_txb.Text = string.Empty;
            receiptRTB.Text = string.Empty;
            string cusID = this.chooseCustCmb.GetItemText(this.chooseCustCmb.SelectedItem);
            paymentAndCompletion obj1 = new paymentAndCompletion();
            obj1.forGenerateRandT(cusID,receiptRTB,total_txb);
        }

        public void cusPayment_Load(object sender, EventArgs e)
        {
            ArrayList cusID = new ArrayList();
            cusID = paymentAndCompletion.retrieveCusID();
            foreach (var item in cusID)
            {
                chooseCustCmb.Items.Add(item);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (receiptRTB.Text == string.Empty)
            {
                MessageBox.Show("No receipt to be print!");
            }
            else
            {
                e.Graphics.DrawString(receiptRTB.Text, new Font("Cascadia Mono", 18, FontStyle.Regular), Brushes.Black, new Point(5, 5));
            }
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            receiptRTB.Text = string.Empty;
            total_txb.Text = string.Empty;
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {

        }

        //public void addCustomerID(Array cusID, ComboBox box)
        //{
        //for (int i = 0; i < cusID.Length; i++)
        //{
        // box.Items.Add(cusID);
        //}

        //}
    }
}
