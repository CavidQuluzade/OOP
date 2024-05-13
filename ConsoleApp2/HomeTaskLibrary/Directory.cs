using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLibrary
{
    internal class Directory
    {
        public string Name { get; set; }
        private Book[] books;
        public Book[] Books { get { return books; } }
        public Directory(string name)
        {
            Name = name;
            books = new Book[0];
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void GetBooks()
        {
            foreach (var book in books)
            {
                book.GetBook();
            }
        }
        public void RemoveBook(Book book)
        {
            var index = Array.IndexOf(books, book);
            if (index != -1)
            {
                for (int i = index; i < books.Length - 1; i++)
                {
                    books[i] = books[i + 1];
                    Array.Resize(ref books, books.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don;t have this book in this directory");
            }
        }
        public void GetDirectory()
        {
            Console.WriteLine($"Directory {Name}");
        }
    }

}
