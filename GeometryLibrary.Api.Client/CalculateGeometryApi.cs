using GeometryLibrary.Model;
using GeometryLibrary.Service;
using GeometryLibrary.Utils;
using System;

/*
 * *************************************************************************************
 * 
 * Деталей задания мало, но в целом понятно. Интересное задание, вроде звучит просто,
 * но заставило задуматься.
 * 
 * По заданию с sql, не совсем понятно в каком виде хранятся данные, возможно сложность 
 * возникла из за неудачного варианта реализации, продублирую запрос тут, в репозитории 
 * прикреплена картинка с результатом
 * 
 * SELECT Products.Name, COALESCE(Categories.Name, 'без категории') AS Category
   FROM Products
   LEFT JOIN ProductCategoriesMap ON Products.Id = ProductCategoriesMap.ProductId
   LEFT JOIN Categories ON ProductCategoriesMap.CategoryId = Categories.Id
   ORDER BY Products.Name ASC, Categories.Name ASC;
 * 
 ************************** P.S. Буду рад получить feedback ****************************
 */

namespace GeometryLibrary.Api.Client
{
    public class CalculateGeometryApi
    {
        private CalculateGeometry _calculateGeometry = new CalculateGeometry();
          
        /// <summary>
        /// Возращает площадь фигуры
        /// Второй вариант, посчет площади фигуры реализован в отдельном классе
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public double GetArea(Shape shape)
        {
            return _calculateGeometry.GetAreaByShape(shape);
        }

        /// <summary>
        /// Возращает площадь круга
        /// Второй вариант
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double GetAreaCircle(double radius)
        {
            if (Validate.IsNegativeNumber(radius))
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");
            }

            return _calculateGeometry.GetAreaCircle(radius);
        }

        /// <summary>
        /// Возращает площадь круга
        /// </summary>
        /// <param name="circle"></param>
        /// <returns></returns>
        public double GetAreaCircle(Circle circle)
        {
            return _calculateGeometry.GetAreaCircle(circle);
        }

        /// <summary>
        /// Возращает площадь треугольника
        /// Второй вариант
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double GetAreaTriangle(double a, double b, double c)
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

            return _calculateGeometry.GetAreaTriangle(a, b, c);
        }

        /// <summary>
        /// Возращает площадь треугольника
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public double GetAreaTriangle(Triangle triangle)
        {
            return _calculateGeometry.GetAreaTriangle(triangle);
        }

        /// <summary>
        /// Возращает true, если треугольник прямоугольный
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public bool IsRightTriangle(double a, double b, double c)
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

            return _calculateGeometry.IsRightTriangle(a, b, c);
        }

        /// <summary>
        /// Возращает true, есди треугольник является прямоугольным
        /// Второй вариант
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsRightTriangle(Triangle triangle)
        {
            return _calculateGeometry.IsRightTriangle(triangle);
        }
    }
}
