using System;
using System.Runtime.Remoting.Messaging;
using GeometryLibrary.Shapes;
using GeometryLibrary.Shapes.Calculate;
using Xunit;

namespace GeometryLibrary.Test.CalculateAreaTest
{
    public class ShapeAreaTest
    {
        [Theory]
        [InlineData(1d, 3.14d)]
        [InlineData(2d, 12.57d)]
        [InlineData(3d, 28.27d)]
        public void ConstructorCircle_CalculateArea_VerificationTest(double radius, double area)
        {
            var circle = new Circle(radius);
            var calculate = new Calculate();
            double _area = Math.Round(calculate.CalculateArea(circle), 2);

            Assert.Equal(_area, area);
        }

        [Theory]
        [InlineData(1d, 1d, 1d, 0.43d)]
        [InlineData(2d, 3d, 4d, 2.90d)]
        [InlineData(4d, 5d, 7d, 9.80d)]
        public void ConstructorTriangle_CalculateArea_VerificationTest(double sideA, double sideB, double sideC, double area)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var calculate = new Calculate();
            double _area = Math.Round(calculate.CalculateArea(triangle), 2);

            Assert.Equal(_area, area);
        }
    }
}
