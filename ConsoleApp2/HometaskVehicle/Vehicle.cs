using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskVehicle
{
    internal class Vehicle
    {
        public string Name;
        public string Color;
        public int Year;

        public Vehicle(string name, string color, int year)
        {
            this.Name = name;
            this.Color = color;
            this.Year = year;
        }
        public virtual string GetDetail()
        {
            return $"{Name} {Color} {Year}";
        } 
    }
}
