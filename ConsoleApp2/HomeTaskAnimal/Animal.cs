using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Animal(string name, int age, string type, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
            this.Color = color;
        }
        
        public abstract void MakeVoice();
    }
}
