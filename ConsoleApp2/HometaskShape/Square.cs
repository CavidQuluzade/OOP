using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskShape
{
    internal class Square : Shape
    {
        public int Side { get; set; }
        public Square(int Side) 
        {
            this.Side = Side;
        }
        public override double FindArea()
        {
            Area = Side * Side;
            return Area;
        }
    }
}
