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
    public partial class registerCus : Form
    {
        public registerCus()
        {
            InitializeComponent();
        }

        private void resetCus_Click(object sender, EventArgs e)
        {
            entName_txb.Text = String.Empty;
            passTxb.Text = String.Empty;
            entLbrand_txb.Text = String.Empty;
            entLserial_txb.Text = String.Empty;
        }

        private void registerCus_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainMenuRecep mmr = new mainMenuRecep();
            this.Close();
            mmr.Show();
            Visible = false;
        }

        private void confrmCus_Click(object sender, EventArgs e)
        {
            //entName_txb entLbrand_txb entLserial_txb urgencyCmb serviceCmb
            string name;
            string passw;
            //string brand;
            //string serial;
            //string urgencys;
            //string chosenService;

            name = entName_txb.Text;
            passw = passTxb.Text;
            //brand = entLbrand_txb.Text;
            //serial = entLserial_txb.Text;
            //urgencys = urgencyCmb.SelectedItem.ToString();
            //chosenService = serviceCmb.SelectedItem.ToString();
            registerCustomerAndOrder obj1 = new registerCustomerAndOrder(entName_txb.Text, passTxb.Text, entLbrand_txb.Text, entLserial_txb.Text, urgencyCmb.SelectedItem.ToString(), serviceCmb.SelectedItem.ToString());
            namePassVal(name, passw);
            if (namePassVal(name, passw) == true)
            {
                //obj1.registerCustomerAndOrders(name, passw, brand, serial, urgencys, chosenService);
                MessageBox.Show(obj1.addCustomer());

                mainMenuRecep mmr = new mainMenuRecep();
                mmr.Show();
                Visible = false;
            }
            else if (namePassVal(name, passw) == false)
            {
                MessageBox.Show("Please try again!");
            }

          

        }

        private bool namePassVal(string name, string passw)
        {
            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    return true;
                    break;
                }
                else
                {
                    MessageBox.Show("No digits & symbols allowed in the name!");
                    break;
                }
            }

            if (name == "" || passw == "")
            {
                MessageBox.Show("Username or Password cannot be Empty!");
            }
            else
            {
                return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urgencyCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            urgencyCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void serviceCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
