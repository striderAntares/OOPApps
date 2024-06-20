using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GeometricShape
{
    internal abstract class GeometricShapes
    {
        public int Height { get; set; }
        public int Floor { get; set; }
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }
}
