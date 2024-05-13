using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskVehicle
{
    internal class TruckVehicle : Vehicle
    {
        public int Capacity { get; set; }
        public TruckVehicle(string name, string color, int year, int capacity) : base(name, color, year)
        {
            Capacity = capacity;
        }
        public override string GetDetail()
        {
            return $"{Name}, {Color}, {Year}, {Capacity}";
        }
    }
}
