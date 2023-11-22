using System;

namespace GeometryLibrary.Exeptions
{
    public class NumberIsNegativeExeption : ArgumentException
    {
        public NumberIsNegativeExeption() 
            : base("Параметр не может быть отрицательным числом") { }
    }
}
