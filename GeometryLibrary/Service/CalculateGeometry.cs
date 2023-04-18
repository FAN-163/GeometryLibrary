using GeometryLibrary.Model;
using GeometryLibrary.Utils;
using System;

namespace GeometryLibrary.Service
{
   public class CalculateGeometry
    {
        /// <summary>
        /// Возращает площадь фигуры в зависимости от ее типа
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double GetAreaByShape(Shape shape)
        {
            if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                return GetAreaCircle(circle);
            }
            else if (shape is Triangle)
            {
                Triangle triangle = (Triangle)shape;
                return GetAreaTriangle(triangle);
            }
            else
            {
                throw new ArgumentOutOfRangeException("На является Shape");
            }   
        }

        /// <summary>
        /// Возращает площадь круга по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double GetAreaCircle(double radius)
        {
            var S = Math.PI * Math.Pow(radius, 2);
            return S;
        }

        /// <summary>
        /// Возращает площадь круга
        /// </summary>
        /// <param name="circle"></param>
        /// <returns></returns>
        public double GetAreaCircle(Circle circle)
        {
            return GetAreaCircle(circle.Radius);
        }

        /// <summary>
        /// Возращает площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double GetAreaTriangle(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        /// <summary>
        /// Возращает площадь треугольника
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public double GetAreaTriangle(Triangle triangle)
        {
            return GetAreaTriangle(triangle.SideA, triangle.SideB, triangle.SideC);
        }

        /// <summary>
        /// Возращает true, если треугольник прямоугольный, по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);

            if (sides[2] > sides[1])
            {
                var sumSqrCathets = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
                var sqrHypotenuse = Math.Pow(sides[2], 2);
                var epsilon = 0.00001;
                var result = Math.Abs(sumSqrCathets - sqrHypotenuse) < epsilon;
                return result;
            }
            return false;
        }

        /// <summary>
        /// Возращает true, если треугольник прямоугольный
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public bool IsRightTriangle(Triangle triangle)
        {
            return IsRightTriangle(triangle.SideA, triangle.SideB, triangle.SideC);
        }
    }
}
