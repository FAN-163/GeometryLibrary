using GeometryLibrary.Abstraction.Factory;
using GeometryLibrary.Abstraction.Shapes;
using GeometryLibrary.Exeptions;

namespace GeometryLibrary.Shapes.Factory
{
    public class ShapeFactory : IShapeFactory
    {
        public IShapeArea CreateFigure(params double[] parameters)
        {
            switch (parameters.Length)
            {
                case 1:
                    return new CircleFactory().CreateFigure(parameters[0]);
                case 3: 
                    return new TriangleFactory().CreateFigure(parameters[0], parameters[1], parameters[1]);
                default:
                    throw new NotExistedShapeExeption();
            }
        }
    }
}
