using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTaskProduct
{
    internal class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, double price, string size) : base(name, price)
        {
            Size = size;
        }

        public override string GetProductDetail()
        {
            return $"{Name}, {Price}, {Size}";
        }
    }
}
