using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDocument
{
    internal class BasicDocument
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened");
        } 
        public virtual void EditDocument() 
        {
            Console.WriteLine("Can edited in pro and expert edition");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Can saved in pro and expert edition");
        }
    }
}
