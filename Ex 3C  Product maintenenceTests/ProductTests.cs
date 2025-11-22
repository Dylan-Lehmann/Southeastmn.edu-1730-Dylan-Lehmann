using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_3C__Product_maintenence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3C__Product_maintenence.Tests
{
    [TestClass()]
    public class ProductTests
    {
        Product product = new("ABC", "New Product", 35.0m);
        [TestMethod()]
        public void ProductTest()
        {
           
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.Description);
            Assert.IsNotNull(product.Price);
            Assert.IsNotNull(product.Code);
            Assert.AreEqual(product.Code, "ABC");
            Assert.AreEqual(product.Description, "New Product");
            Assert.AreEqual(product.Price, 35.0m);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(product.ToString(), "ABC\t35.00\tNew Product");
        }
    }
}