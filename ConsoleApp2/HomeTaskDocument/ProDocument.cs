using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDocument
{
    internal class ProDocument : BasicDocument
    {
        public  override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in doc format for pdf by expert");
        }
    }
}
