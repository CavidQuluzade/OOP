using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskShape
{
    internal class Triangle : Shape
    {
        public int Height { get; set; }
        public int Side { get; set; }
        public Triangle(int height, int side) 
        {
            this.Height = height;
            this.Side = side;
        }
        public override double FindArea() 
        {
            Area = (Height*Side)/2;
            return Area;
        }
    }
}
