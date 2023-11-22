using System;
using GeometryLibrary.Abstraction.Shapes;
using GeometryLibrary.Exeptions;
using GeometryLibrary.Utils;

namespace GeometryLibrary.Shapes
{
    public class Triangle : IShapeArea
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (Validate.IsNegativeNumber(sideA) || Validate.IsNegativeNumber(sideB) || Validate.IsNegativeNumber(sideC))
                throw new NumberIsNegativeExeption();
         
            if (Validate.IsZero(sideA) || Validate.IsZero(sideB) || Validate.IsZero(sideC))
                throw new NumberIsZeroExeption();
            
            if (Validate.IsNotExistedTriangle(sideA, sideB, sideC))
                throw new NotExistedTriangleException();
           
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2d;
            double S = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return S;
        }

        public bool IsRight()
        {
            var hypotenuse = Math.Max(SideA, Math.Max(SideB, SideC));
            var sqrHypotenuse = Math.Pow(hypotenuse, 2);
            var epsilon = 0.00001;
            var sumSqrSide = Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
            var result = Math.Abs(sumSqrSide - sqrHypotenuse * 2) < epsilon;

            return result;
        }
    }
}
