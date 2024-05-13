using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLibrary
{
    internal class Book
    {
        public string Name { get; set; }
        public int Page { get; set; }
        public Book(string name, int page) 
        {
            this.Name = name;
            this.Page = page;
        }
        public void GetBook()
        {
            Console.WriteLine($"Book - {Name} {Page}");
        }
    }
}
