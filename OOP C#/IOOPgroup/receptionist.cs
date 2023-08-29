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
    public partial class Frm_AddRecept : Form
    {
        
        public Frm_AddRecept()
        {
            InitializeComponent();
            
        }
        

        private void btn_createRecept_Click(object sender, EventArgs e)
        {
            Add_Users obj1 = new Add_Users(txtBox_email.Text, txtBox_pass.Text, "Receptionist");
            MessageBox.Show(obj1.add_recept());
            txtBox_email.Clear();
            txtBox_pass.Clear();
        }

        private void Frm_AddRecept_Load(object sender, EventArgs e)
        {
            // disable button at the beginnning
            btn_createRecept.Enabled = false;

            if (txtBox_email.CanSelect)
                txtBox_email.Select();
        }

      

        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            // enable button after user input in txtbox
            if (txtBox_email.Text != "" && txtBox_pass.Text != "")
            {
                btn_createRecept.Enabled = true;
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
