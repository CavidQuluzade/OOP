using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskShape
{
    internal abstract class Shape
    {
        public double Area { get; protected set; }
        public abstract double FindArea();
        
    }
}
