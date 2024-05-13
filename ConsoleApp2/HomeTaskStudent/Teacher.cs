using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Teacher(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void GetTeacherDetail()
        {
            Console.WriteLine($"Teacher: {Name} {Surname}");
        }
    }
}
