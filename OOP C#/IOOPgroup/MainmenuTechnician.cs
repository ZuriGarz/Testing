using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace IOOPgroup
{
    public partial class TechnicianMenu : Form
    {
        public static string NameTech;

        public TechnicianMenu()
        {
            InitializeComponent();
        }

        public TechnicianMenu(string n)
        {
            InitializeComponent();
            NameTech = n;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            //Login f1 = new Login();
            this.Close();
            //f1.ShowDialog();  //for go to another form
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string Urgency = "Urgent";
            int i = 0;
            while (i == 0)
                if (UrgentBtn.Checked)
                {
                    if (List1.SelectedItem.ToString == null)
                        MessageBox.Show("Retry");
                    else if (List1.SelectedItem.ToString != null)
                        this.Hide();
                        Review f2 = new Review(List1.SelectedItem.ToString(), Urgency);
                        f2.ShowDialog(); //to go to another form
                        break;
                }
                else if (NormalBtn.Checked)
                {
                    if (List2.SelectedItem.ToString == null)
                        MessageBox.Show("Retry");
                    else if (List2.SelectedItem.ToString != null)
                        Urgency = "Normal";
                        this.Hide();
                        Review f2 = new Review(List2.SelectedItem.ToString(), Urgency);
                        f2.ShowDialog(); //to go to another form
                        break;
                }
            this.Show();

        }

       

        private void TechnicianMenu_Load(object sender, EventArgs e)
        {
            ArrayList All = new ArrayList();
            All = Technician.ViewAllTechU();
            foreach (var item in All)
            {
                List1.Items.Add(item);
            }
            

            ArrayList All2 = new ArrayList();
            All2 = Technician.ViewAllTechN();
            foreach (var item in All2)
            {
                List2.Items.Add(item);
            }
            
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();           
            UpdateTechnician f3 = new UpdateTechnician(NameTech);
            f3.ShowDialog(); //to go to another form
            this.Show();
            
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            List1.Items.Clear();
            List2.Items.Clear();
            ArrayList All = new ArrayList();
            All = Technician.ViewAllTechU();
            foreach (var item in All)
            {
                List1.Items.Add(item);
            }


            ArrayList All2 = new ArrayList();
            All2 = Technician.ViewAllTechN();
            foreach (var item in All2)
            {
                List2.Items.Add(item);
            }
        }

        private void List1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string check1 = "1";
            Technician Check = new Technician(List1.Text, check1);
            UrgentBtn.Checked = true;
        }

        private void List2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check1 = "1";
            Technician Check = new Technician(List2.Text, check1);
            NormalBtn.Checked = true;   
        }
    }
}