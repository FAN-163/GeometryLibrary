using GeometryLibrary.Exeptions;
using GeometryLibrary.Shapes;
using Xunit;

namespace GeometryLibrary.Test.ShapesTest
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1d)]
        [InlineData(2d)]
        [InlineData(10000d)]
        public void CircleConstructor_ValidRadius_CreatesCircleWithSameRadius(double radius)
        {
            var circle = new Circle(radius);
            
            Assert.Equal(radius, circle.Radius);
        }

        [Theory]
        [InlineData(-1d)]
        [InlineData(-2d)]
        [InlineData(-10000d)]
        public void CircleConstructor_NegativeRadius_ThrowsNumberIsNegativeExeption(double radius)
        { 
            Assert.Throws<NumberIsNegativeExeption>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(0)]
        public void CircleConstructor_ZeroRadius_ThrowsNumberIsZeroExeption(double radius)
        {
            Assert.Throws<NumberIsZeroExeption>(() => new Circle(radius));
        }
    }
}
