namespace Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblClickCounter_Click(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblClickCounter.Text = "Hallo Magnus!!!!!!";
        }
    }
}
