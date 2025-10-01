namespace ex1b
{
    public partial class FormInvoiceTotal : Form
    {
        int numberOfInvoices;
        decimal totalOfInvoices;
        decimal avgOfInvoices;
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
            decimal subtotal = Convert.ToDecimal(textBoxEnterSubtotal.Text);
            decimal discountpercent = 0.25m;
            decimal discountamount = Math.Round(subtotal * discountpercent, 2);
            decimal total = Math.Round(subtotal - discountamount, 2);

            textBoxSubtotal.Text = subtotal.ToString("c");
            textBoxDiscountpercent.Text = discountpercent.ToString("p1");
            textBoxDiscountamount.Text = discountamount.ToString("c");
            textBoxTotal.Text = total.ToString("c");

            numberOfInvoices += 1; 
            totalOfInvoices += total;
            avgOfInvoices = totalOfInvoices / numberOfInvoices;

            textBoxNmbInvoices.Text = numberOfInvoices.ToString();
            textBoxAvgInvoices.Text = avgOfInvoices.ToString("c");
            textBoxTotalInvoices.Text = totalOfInvoices.ToString("c");

            textBoxEnterSubtotal.Text = "";
            textBoxEnterSubtotal.Focus();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            avgOfInvoices = 0m;

            textBoxNmbInvoices.Text = "";
            textBoxAvgInvoices.Text = "";
            textBoxTotalInvoices.Text = "";
            textBoxSubtotal.Text = "";
            textBoxDiscountpercent.Text = "";
            textBoxDiscountamount.Text = "";
            textBoxTotal.Text = "";

            textBoxEnterSubtotal.Focus();
        }
    }
}
