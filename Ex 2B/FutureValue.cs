namespace Ex_2B
{
    public partial class Future_Value : Form
    {
        public Future_Value()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyinvestment = Convert.ToDecimal(textBoxMonthInvest.Text);
            decimal yearlyinterestRate = Convert.ToDecimal(textBoxYIR.Text);
            int years = Convert.ToInt16(textBoxNmbYears.Text);

            decimal monthlyinterestrate = yearlyinterestRate / 12 / 100 ;
            int months = years * 12;
         
            decimal futurevalue = 0m;

            for (int i = 0; i < months; i++)
            {
                futurevalue = (futurevalue + monthlyinvestment) * (1 + monthlyinterestrate);
            }

            textBoxFutureValue.Text = futurevalue.ToString("c");
            textBoxMonthInvest.Focus();
        }
    }
}
