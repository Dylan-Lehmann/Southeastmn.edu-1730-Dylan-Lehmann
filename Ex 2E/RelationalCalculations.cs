using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2E
{
    public class RelationalCalculations
    {
        public static bool IsFrank(string input)
        {if (input == "Frank" )
                return true;
            else
                return false; }

        public static bool IsEmpty(string input)
        {
            if (input == "")
                return true;
            else
                return false;
        }
            
            

        public static bool IsTwoPointThree(string input)
        {
            if (input == "2.3")
                return true;
            else
                return false;
        }

        public static bool IsFalse(string input)
        {
            if (input == "false")
                return true;
            else
                return false;
        }

        public static bool AreEqual(string inputA, string inputB)
        {
            if (inputA == inputB)
                return true;
            else
                return false;
        }

        public static bool IsNotJones(string input)
        {
            if (input != "Jones")
                return true;
            else
                return false;
        }

        public static bool IsLargerThanZero(string input)
        {
            if (Convert.ToDecimal(input) >0)
                return true;
            else
                return false;
        }

        public static bool IsLessThan(string inputA, string inputB)
        {
            if (Convert.ToDecimal(inputA) < Convert.ToDecimal(inputB))
                return true;
            else
                return false;
        }

        public static bool IsLargerOrEquals500(string input)
        {
            if (Convert.ToDecimal(input) >= 500)
                return true;
            else
                return false;
        }

        public static bool IsLessOrEqualsThan(string inputA, string inputB)
        {
            if (Convert.ToDecimal(inputA) <= Convert.ToDecimal(inputB))
                return true;
            else
                return false;
        }

   
    }
}
