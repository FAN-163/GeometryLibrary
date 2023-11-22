using GeometryLibrary.Abstraction.Factory;
using GeometryLibrary.Abstraction.Shapes;

namespace GeometryLibrary.Shapes.Factory
{
    public class TriangleFactory : IShapeFactory
    {
        public IShapeArea CreateFigure(params double[] parameters)
        {
            return new Triangle(parameters[0], parameters[1], parameters[2]);
        }
    }
}
