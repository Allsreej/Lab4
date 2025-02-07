using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using Lab3;
using NUnit.Framework.Legacy;
using NUnit.Framework;

namespace Lab3.Tests
{/// <summary>
/// Student Name : Sreeja Alla
/// Student Number : 8967281
/// </summary>
    [TestFixture]
    public class IsoscelesTriangleTests
    {
        [Test]
        public void ValidIsoscelesTriangle_Input6and6and7_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 6;
            int secondSide = 6;
            int thirdSide = 7;
            string expected = "The triangle is valid Isosceles triangle.";

            //Act 
            string actual = IsoscelesTriangle.ValidIsoscelesTriangle(firstSide, secondSide, thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidIsoscelesTriangle_Input5and6and7_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 7;
            string expected = "The triangle is valid Isosceles triangle.";

            //Act 
            string actual = IsoscelesTriangle.ValidIsoscelesTriangle(firstSide, secondSide, thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);

        }
        [Test]
        public void ValidIsoscelesTriangle_Input6and5and5_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 7;
            string expected = "The triangle is valid Isosceles triangle.";

            //Act 
            string actual = IsoscelesTriangle.ValidIsoscelesTriangle(firstSide, secondSide, thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);

        }
    }
}
