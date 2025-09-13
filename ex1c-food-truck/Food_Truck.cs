using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1c_food_truck
{
    public partial class Food_Truck : Form
    {
        public Food_Truck()
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
            //There was an error if I left this one blank
            textBoxTotal.Text = textBoxBlank.Text;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Calculate Everything.
            //I should have split up this big piece of code to be more readable.
            decimal HotdogCost = Convert.ToDecimal(4.00);
            decimal HamburgerCost = Convert.ToDecimal(5.00);
            decimal TotalHotdogCost = HotdogCost * Convert.ToDecimal(textBoxHotdogs.Text);
         textBoxHdTotal.Text = TotalHotdogCost.ToString();
            decimal TotalHamburgerCost = HamburgerCost * Convert.ToDecimal(textBoxHamburgers.Text);
            textBoxHbTotal.Text = TotalHamburgerCost.ToString();
            decimal PretaxTotal = TotalHotdogCost + TotalHamburgerCost;
            textBoxPtTotal.Text = PretaxTotal.ToString();
            decimal TaxPercent = Convert.ToDecimal(0.0687);
                decimal Tax = TaxPercent * PretaxTotal;
            textBoxTax.Text = Tax.ToString();
            decimal Total = Tax + PretaxTotal;
            textBoxTotal.Text = Total.ToString();
                }
    }
}
