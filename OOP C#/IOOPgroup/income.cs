namespace IOOPgroup
{
    public partial class Frm_Income : Form
    {
        public Frm_Income()
        {
            InitializeComponent();
        }

        private void Btn_Main_Click(object sender, EventArgs e)
        {
            string a = "";
            this.Hide();
            Frm_Main_admin ma = new Frm_Main_admin(a);
            ma.ShowDialog();
            this.Close();
        }

        private void btn_viewincome_Click(object sender, EventArgs e)
        {
            ViewData income = new ViewData();
            
            try
            {
                string x = income.ViewMonthlyIncome(textBox1.Text).ToString();
                label_display_income.Text = "total income in month " + textBox1.Text + " is " + x + " RM";
            }
            catch
            {
                label_display_income.Text = "total income in month " + textBox1.Text + " is 0 RM";
            }
            textBox1.Text = "";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //enable button after user input
            if (textBox1.Text != null)
                btn_viewincome.Enabled = true;
        }

        private void Frm_Income_Load(object sender, EventArgs e)
        {
            //disable button at form load
            btn_viewincome.Enabled = false;
        }
    }
}