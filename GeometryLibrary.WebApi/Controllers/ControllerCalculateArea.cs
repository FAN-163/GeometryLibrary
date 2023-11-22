using GeometryLibrary.Shapes.Calculate;
using GeometryLibrary.Shapes.Factory;
using Microsoft.AspNetCore.Mvc;

namespace GeometryLibrary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerCalculateArea : ControllerBase
    {
        private readonly Calculate _calculate = new();

        [HttpGet]
        [Route("/CircleArea")]
        public double GetCircleArea(double radius)
        {
            var circleCreator = new CircleFactory();
            var circle = circleCreator.CreateFigure(radius);

            var area = _calculate.CalculateArea(circle);
            return Math.Round(area);
        }

        [HttpGet]
        [Route("/TriangleArea")]
        public double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var triangleCreator = new TriangleFactory();
            var triangle = new ShapeFactory().CreateFigure(sideA, sideB, sideC);

            var area = _calculate.CalculateArea(triangle);
            return Math.Round(area);
        }

        [HttpPost]
        [Route("/ShapeArea")]
        public double GetShapeArea(double[] parameters)
        {
            var shapeCreator = new ShapeFactory();
            var shape = shapeCreator.CreateFigure(parameters);

            var area = _calculate.CalculateArea(shape);
            return Math.Round(area);
        }
    }
}
