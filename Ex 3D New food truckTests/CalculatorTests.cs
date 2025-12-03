using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_3D_New_food_truck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3D_New_food_truck.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void HotdogSubtotalTest()
        {
            var order = new Calculator();
            Assert.AreEqual(order.HotdogSubtotal(3), 3*4);
        }

        [TestMethod()]
        public void HamburgerSubtotalTest()
        {
            var order = new Calculator();
            Assert.AreEqual(order.HamburgerSubtotal(4), 4*5);
        }

        [TestMethod()]
        public void SubtotalTest()
        {
            var order = new Calculator();
            Assert.AreEqual(order.Subtotal(1,1), 2);
        }

        [TestMethod()]
        public void TaxTest()
        {
            var order = new Calculator();
            Assert.AreEqual(order.Tax(1), Convert.ToDecimal(0.0687));
         
        }

        [TestMethod()]
        public void TotalTest()
        {
            var order = new Calculator();
            Assert.AreEqual(order.Total(1, 1), 2);
        }
    }
}