using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskProduct
{




    internal class Electronic : Product
    {
        public string Material { get; set; }
        public Electronic(string name, double price, string material) : base(name, price)
        {
            Material = material;
        }
        public override string GetProductDetail()
        {
            return $"{Name}, {Price}, {Material}";
        }
    }
}
