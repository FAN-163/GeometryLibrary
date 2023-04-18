using GeometryLibrary.Model;
using GeometryLibrary.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.GeometryLibrary
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void IsNegativeNumber_WithNumber1_ReturnsTrue()
        {
            // Arrange
            double number = -1;

            // Act
            bool isNegative = Validate.IsNegativeNumber(number);

            // Assert
            Assert.IsTrue(isNegative);
        }

        [TestMethod]
        public void IsNonexistentTriangle_WithSides1_4_5_ReturnsTrue()
        {
            // Arrange
            double a = 1;
            double b = 4;
            double c = 5;

            // Act
            bool isNegative = Validate.IsNonexistentTriangle(a, b, c);

            // Assert
            Assert.IsTrue(isNegative);
        }
    }
}
