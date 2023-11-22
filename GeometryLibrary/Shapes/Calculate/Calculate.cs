using GeometryLibrary.Abstraction.Shapes;

namespace GeometryLibrary.Shapes.Calculate
{
    public class Calculate
    {
        public double CalculateArea(IShapeArea shape)
        {
            return shape.CalculateArea();
        }
    }
}
