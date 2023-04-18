using GeometryLibrary.Model;
using GeometryLibrary.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.GeometryLibrary
{
    [TestClass]
    public class CalculateGeometryTest
    {
        private CalculateGeometry _calculate = new CalculateGeometry();


        [TestMethod]
        public void GetArea_WithRadius1_ReturnsPI()
        {
            // Arrange
            double radius = 1;

            // Act
            double area = _calculate.GetAreaCircle(radius);

            // Assert
            Assert.AreEqual(Math.PI, area);
        }

        public void GetArea_WithRadius1_ReturnsPI_ByShape()
        {
            // Arrange
            Circle circle = new Circle(1);

            // Act
            double area = _calculate.GetAreaCircle(circle);

            // Assert
            Assert.AreEqual(Math.PI, area);
        }

        [TestMethod]
        public void GetArea_WithSides3_4_5_Returns6()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            double area = _calculate.GetAreaTriangle(a, b, c);

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void GetArea_WithSides3_4_5_Returns6_ByShape()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            double area = _calculate.GetAreaTriangle(triangle);

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void IsRightTriangle_WithSides3_4_5_ReturnsTrue()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            bool isRightTriangle = _calculate.IsRightTriangle(a, b, c);

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangle_WithSides3_4_5_ReturnsTrue_ByShape()
        {

            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = _calculate.IsRightTriangle(triangle);

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void GetAreaByShape_WithRadius1_ReturnsPI_ByShape()
        {
            // Arrange
            Shape shape = new Circle(1);
            // Act
            double area = _calculate.GetAreaByShape(shape);

            // Assert
            Assert.AreEqual(Math.PI, area);
        }
    }
}
