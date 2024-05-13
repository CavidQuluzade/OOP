using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent
{
    internal class Topic
    {
        public string Name { get; set; }
        public Topic(string name) 
        {
            this.Name = name;
        }
        public void GetTopicDetail()
        {
            Console.WriteLine($"Topic: {Name}");
        }
    }
}
