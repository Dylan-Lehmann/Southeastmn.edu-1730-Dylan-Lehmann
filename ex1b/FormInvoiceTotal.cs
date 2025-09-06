namespace ex1b
{
    public partial class FormInvoiceTotal : Form
    {
        public FormInvoiceTotal()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            this.textBoxTotal.Text = this.textBoxSubtotal.Text;
        }
    }
}
