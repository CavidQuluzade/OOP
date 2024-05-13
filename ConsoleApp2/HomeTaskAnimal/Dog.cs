using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string type, string color): base(name, age, type, color)
        {

        }
        public void GetDetail()
        {
            Console.WriteLine( $"{Name} {Age} {Type} {Color}");
        }
        public override void MakeVoice() 
        {
            Console.WriteLine("Haaav");
        }
    }
}
