using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3D_New_food_truck
{
    public class Calculator
    {
       decimal HotDogCost = 4;
        decimal HamburgerCost = 5;
        decimal TaxRate = Convert.ToDecimal(0.0687);
        

        public decimal HotdogSubtotal(int Hotdogs)
        { return Hotdogs * HotDogCost; }

        public decimal HamburgerSubtotal(int Hamburgers)
        { return Hamburgers * HamburgerCost; }

        public decimal Subtotal(decimal HotdogSubtotal, decimal HamburgerSubtotal)
        { return HotdogSubtotal + HamburgerSubtotal; }
        public decimal Tax(decimal subtotal)
        { return subtotal * TaxRate; }

        public decimal Total(decimal Subtotal, decimal Tax)
        {return Subtotal + Tax;}
    }
}
