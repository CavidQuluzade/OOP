using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskVehicle
{
    internal class CarVehicle : Vehicle
    {
        public int Passengers {  get; set; }
        public CarVehicle(string name, string color, int year, int passengers):base(name, color, year) 
        {
            Passengers = passengers;
        }
        public override string GetDetail()
        {
            return $"{Name}, {Color}, {Year}, {Passengers}";
        }
    }
}
