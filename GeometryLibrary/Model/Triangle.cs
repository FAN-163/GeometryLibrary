using System;
using GeometryLibrary.Utils;

namespace GeometryLibrary.Model
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA { get => _sideA; }
        public double SideB { get => _sideB; }
        public double SideC { get => _sideC; }


        public Triangle(double a, double b, double c)
        {
            if (Validate.IsNegativeNumber(a) ||
                Validate.IsNegativeNumber(b) ||
                Validate.IsNegativeNumber(c))
            {
                throw new ArgumentOutOfRangeException("Стороны треугольника не могут быть меньше 0");
            }
            if (Validate.IsNonexistentTriangle(a, b, c))
            {
                throw new ArgumentOutOfRangeException("Треугольник с такими параметрами не существует, сумма двух сторон должна быть больше третьей");
            }

            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами a - {_sideA}, b - {_sideB}, c - {_sideC}";
        }

        
    }
}
