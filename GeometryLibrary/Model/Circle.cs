using GeometryLibrary.Utils;
using System;

namespace GeometryLibrary.Model
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius { get => _radius; }

        public Circle(double radius)
        {
            if (Validate.IsNegativeNumber(radius))
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");
            }

            _radius = radius;
        }
        public override string ToString()
        {
            return $"Круг с радиусом - {_radius}";
        }
    }
}
