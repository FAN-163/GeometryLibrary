using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Utils
{
    public class Validate
    {
        public static bool IsNonexistentTriangle(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                return false;
            }
            return true;
        }

        public static bool IsNegativeNumber(double input)
        {
           return input < 0 ? true : false;
        }
    }
}
