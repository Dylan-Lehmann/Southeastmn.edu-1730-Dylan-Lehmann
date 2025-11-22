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
    public class SoftwareTests
    {
        Software software = new Software("ABC", "New Software", 55.9m, "5.2");
        [TestMethod()]
        public void SoftwareTest()
        {
            
            Assert.IsNotNull(software);
            Assert.IsNotNull(software.Description);
            Assert.IsNotNull(software.Version);
            Assert.IsNotNull(software.Price);
            Assert.IsNotNull(software.Code);
            Assert.AreEqual(software.Code, "ABC");
            Assert.AreEqual(software.Description, "New Software");
            Assert.AreEqual(software.Price, 55.9m);
            Assert.AreEqual(software.Version, "5.2");

        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(software.ToString(), "ABC\t55.90\tNew Product\tVersion 5.2");
        }
    }
}