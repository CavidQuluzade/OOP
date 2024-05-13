using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskShape
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double FindArea()
        {
            double pi = 3.14;
            Area= pi*Radius*Radius;
            return Area;
        }
    }
}
