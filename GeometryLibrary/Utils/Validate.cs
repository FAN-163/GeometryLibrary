using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Utils
{
    public static class Validate
    {
        public static bool IsNotExistedTriangle(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                return false;
            }
            return true;
        }

        public static bool IsNegativeNumber(double input)
        {
            return input < 0d;
        }

        public static bool IsZero(double input)
        {
            return input == 0d;
        }
    }
}
