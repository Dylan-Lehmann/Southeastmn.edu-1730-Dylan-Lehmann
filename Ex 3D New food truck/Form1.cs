namespace Ex_3D_New_food_truck
{
    public partial class NewFoodTruck : Form
    {
        public NewFoodTruck()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxHotdogs.Text =
          textBoxHamburgers.Text =
          textBoxHdTotal.Text =
          textBoxHbTotal.Text =
          textBoxPtTotal.Text =
          textBoxTax.Text =
           ErrorLabel.Text =
          textBoxTotal.Text = "";

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Calculator order = new Calculator();
                //Set HotDogs and Hamburgers
                var Hotdogs = Convert.ToInt16(textBoxHotdogs.Text);
                var Hamburgers = Convert.ToInt16(textBoxHamburgers.Text);

                //Use the calculator to calculate subtotal,tax, and total
                decimal HotdogSubt = order.HotdogSubtotal(Hotdogs);
                decimal HamburgerSubt = order.HamburgerSubtotal(Hamburgers);
                decimal subtotal = order.Subtotal(HotdogSubt, HamburgerSubt);
                decimal tax = order.Tax(subtotal);
                decimal total = order.Total(subtotal, tax);

                //Put the values in the textboxes
                textBoxHdTotal.Text = HotdogSubt.ToString("C");
                textBoxHbTotal.Text = HamburgerSubt.ToString("C");
                textBoxPtTotal.Text = subtotal.ToString("C");
                textBoxTax.Text = tax.ToString("C");
                textBoxTotal.Text = total.ToString("C");
                ErrorLabel.Text = "";
            }
            catch { ErrorLabel.Text = "Error, use Integers only, fill in both boxes"; }
        }
    }
}
