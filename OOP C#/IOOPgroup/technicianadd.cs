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
    public partial class Frm_AddTech : Form
    {
        public Frm_AddTech()
        {
            InitializeComponent();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            string a = "";
            this.Hide();
            Frm_Main_admin ma = new Frm_Main_admin(a);
            ma.ShowDialog();
            this.Close();
        }

        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            //enable button after input
            if (txtBox_email.Text != null && txtBox_pass.Text != null)
                btn_create.Enabled = true;
        }

        private void Frm_AddTech_Load(object sender, EventArgs e)
        {
            //diable button at beginning
            btn_create.Enabled = false;

            //focus on txtbox username at beginning
            if (txtBox_email.CanSelect)
                txtBox_email.Select();

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Add_Users obj2 = new Add_Users(txtBox_email.Text, txtBox_pass.Text, "Technician");
            MessageBox.Show(obj2.add_tech());
            txtBox_email.Clear();
            txtBox_pass.Clear();
        }
    }
}
