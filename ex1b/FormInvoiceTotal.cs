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
            decimal subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
            decimal discountpercent = 0m;
            if (subtotal >= 500)
            {
                discountpercent = 0.20m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            { discountpercent = 0.15m; }

            else if (subtotal >= 100)
            {
                discountpercent = 0.10m;
            }
            decimal discountamount = subtotal * discountpercent;
            decimal total = subtotal - discountamount;
            textBoxDiscountpercent.Text = discountpercent.ToString();
            textBoxDiscountamount.Text = discountamount.ToString();
            textBoxTotal.Text = total.ToString();
        }
    }
}
