using System;

namespace GeometryLibrary.Exeptions
{
    public class NotExistedTriangleException : ArgumentException
    {
        public NotExistedTriangleException() 
            : base("Нельзя создать треугольник с заданными сторонами"){}
    }
}
