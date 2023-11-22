
using GeometryLibrary.Shapes;
using System.Security.Policy;
using GeometryLibrary.Exeptions;
using Xunit;

namespace GeometryLibrary.Test.ShapesTest
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(1d, 1d, 1d)]
        [InlineData(2d, 2d, 2d)]
        [InlineData(5d, 6d, 7d)]
        [InlineData(7d, 6d, 5d)]
        [InlineData(10000d, 10000d, 10000d)]
        public void TriangleConstructor_ValidSides_CreatesTriangle(double sideA, double sideB, double sideC)
        {
            var ex = Record.Exception(() => new Triangle(sideA, sideB, sideC));

            Assert.Null(ex);
        }
        [Theory]
        [InlineData(-1d, -1d, -1d)]
        [InlineData(-2d, 2d, 2d)]
        [InlineData(5d, -6d, 7d)]
        [InlineData(7d, 6d, -5d)]
        public void TriangleConstructor_NegativeSides_ThrowsNumberIsNegativeExeption(double sideA, double sideB, double sideC)
        {
            Assert.Throws<NumberIsNegativeExeption>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(0d, 0d, 0d)]
        [InlineData(0d, 2d, 2d)]
        [InlineData(5d, 0d, 5d)]
        [InlineData(6d, 6d, 0d)]
        public void TriangleConstructor_ZeroSides_ThrowsNumberIsZeroExeption(double sideA, double sideB, double sideC)
        {
            Assert.Throws<NumberIsZeroExeption>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(1d, 1d, 5d)]
        [InlineData(1d, 5d, 10d)]
        [InlineData(10000d, 5d, 10d)]
        [InlineData(1d, 10000d, 10d)]
        [InlineData(1d, 5d, 10000d)]
        public void TriangleConstructor_NotValidSides_NotExistedTriangleException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<NotExistedTriangleException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(1d, 1d, 1d, false)]
        [InlineData(2d, 2d, 2d, false)]
        [InlineData(10000d, 10000d, 10000d, false)]
        [InlineData(68d, 285d, 293d, true)]
        [InlineData(161d, 240d, 289d, true)]
        [InlineData(247d, 96d, 265d, true)]
        public void IsRightTriangle_VerificationTest(double sideA, double sideB, double sideC, bool isRight)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            
            Assert.Equal(triangle.IsRight(), isRight);
        }
    }
}
