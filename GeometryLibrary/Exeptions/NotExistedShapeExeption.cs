using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Exeptions
{
    public class NotExistedShapeExeption : ArgumentException
    {
        public NotExistedShapeExeption()
            : base("Фигура с заданным количеством параметров не поддерживается") { }
    }
}
