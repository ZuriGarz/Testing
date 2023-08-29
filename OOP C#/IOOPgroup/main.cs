namespace IOOPgroup
{
    public partial class Frm_Main_admin : Form
    {
        //methods work on/inside individual objects while static methods do something for the Class.
        public string name;

        //constructor
        public Frm_Main_admin(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_serviceReport report = new Frm_serviceReport();
            report.ShowDialog();
            this.Close();
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Income income = new Frm_Income();
            income.ShowDialog();
            this.Close();
        }

        private void btn_tech_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AddTech tech = new Frm_AddTech();
            tech.ShowDialog();
            this.Close();
        }

        private void btn_recept_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AddRecept recept = new Frm_AddRecept();
            recept.ShowDialog();
            this.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbl_display_user.Text = "Hello " + name;
        }
    }
}
