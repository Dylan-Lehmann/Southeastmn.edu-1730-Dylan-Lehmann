using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_3A_Student_Grade_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3A_Student_Grade_Calculator.Tests
{
    [TestClass()]
    public class GradingTests
    {
        [TestMethod()]
        public void Expect_A_WhenAverageIsEqual90()
        {

            double average = 91;
            string expectedGrade = "A";
            string actualGrade = Grading.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod()]
        public void Expect_B_WhenAverageIsBetween80and89()
        {

            double average = 85;
            string expectedGrade = "B";
            string actualGrade = Grading.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);

        }
        public void Expect_C_WhenAverageIsBetween70and79()
        {

            double average = 72;
            string expectedGrade = "C";
            string actualGrade = Grading.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);

        }
        public void Expect_D_WhenAverageIsBetween60and69()
        {

            double average = 67;
            string expectedGrade = "D";
            string actualGrade = Grading.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);

        }
        public void Expect_B_WhenAverageBeLow60()
        {

            double average = 41;
            string expectedGrade = "F";
            string actualGrade = Grading.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);

        }
    }
}