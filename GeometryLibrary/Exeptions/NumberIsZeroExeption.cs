using System;

namespace GeometryLibrary.Exeptions
{
    public class NumberIsZeroExeption : ArgumentException
    {
        public NumberIsZeroExeption() 
            : base("Параметр не может быть 0") { }
    }
}
