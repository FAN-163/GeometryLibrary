using GeometryLibrary.Abstraction.Factory;
using GeometryLibrary.Abstraction.Shapes;

namespace GeometryLibrary.Shapes.Factory
{
    public class CircleFactory : IShapeFactory
    {
        public IShapeArea CreateFigure(params double[] parameters)
        {
            return new Circle(parameters[0]);
        }
    }
}
