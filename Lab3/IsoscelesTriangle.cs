using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{/// <summary>
/// Student Name : Sreeja Alla
/// Student Name : 8967281
/// </summary>
    public class IsoscelesTriangle
    {
        public static String ValidIsoscelesTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string result;
            if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                result = "The triangle is valid Isosceles triangle.";
            }
            else
            {
                result = "The triangle is not Isosceles triangle.";
            }
            return result;

        }
    }
}
