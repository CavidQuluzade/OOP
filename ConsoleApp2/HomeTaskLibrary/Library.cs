using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLibrary
{
    internal class Library
    {
        public string Name {  get; set; }
        public int Area { get; set; }
        public string Adress { get; set; }
        private Directory[] directories;
        public Directory[] Directories { get { return directories; } }
        public Library(string name, string adress, int area)
        {
            Name = name;
            Adress = adress;
            directories = new Directory[0];
            Area = area;
        }
        public void AddDirectory(Directory directory)
        {
            Array.Resize(ref directories, directories.Length + 1);
            directories[directories.Length - 1] = directory;
        }
        public void GetDirectory()
        {
            foreach (var d in directories)
            {
                d.GetDirectory();
            }
        }
        public void RemoveDirectory(Directory directory)
        {
            var index = Array.IndexOf(directories, directory);
            if (index != -1)
            {
                for (int i = index; i < directories.Length - 1; i++)
                {
                    directories[i] = directories[i + 1];
                    Array.Resize(ref directories, directories.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don;t have this Directory in this Library");
            }
        }
        public void GetLibraryDetails()
        {
            Console.WriteLine($"{Name} {Adress} {Area}");
        }
    }
}
