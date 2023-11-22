using GeometryLibrary.Abstraction.Shapes;
using System;
using System.Data;
using GeometryLibrary.Exeptions;
using GeometryLibrary.Utils;

namespace GeometryLibrary.Shapes
{
    public class Circle : IShapeArea
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (Validate.IsNegativeNumber(radius))
                throw new NumberIsNegativeExeption();
            

            if (Validate.IsZero(radius))
                throw new NumberIsZeroExeption();
           
            Radius = radius;
        }

        public double CalculateArea()
        {
            double S = Math.PI * Math.Pow(Radius, 2);
            return S;
        }
    }
}
