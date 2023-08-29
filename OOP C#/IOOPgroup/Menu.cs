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
    public partial class Menu : Form
    {
        public static string Username;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string Username1)
        {
            Username = Username1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeRequestService change = new ChangeRequestService(Username);
            change.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfile Updateform = new UpdateProfile(Username);
            Updateform.Show();


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDescription Menu = new ViewDescription(Username);
            Menu.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
