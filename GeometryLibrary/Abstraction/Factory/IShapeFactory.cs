using GeometryLibrary.Abstraction.Shapes;

namespace GeometryLibrary.Abstraction.Factory
{
    public interface IShapeFactory
    {
        IShapeArea CreateFigure(params double[] parameters);
    }
}
