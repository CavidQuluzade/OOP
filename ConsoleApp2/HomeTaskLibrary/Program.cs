using HomeTaskLibrary;

Book book = new Book("AAA", 10);
Book book1 = new Book("BBB", 11);
Book book2 = new Book("CCC", 12);
HomeTaskLibrary.Directory directory = new HomeTaskLibrary.Directory("Detective");
HomeTaskLibrary.Directory directory1 = new HomeTaskLibrary.Directory("Action");
Library library = new Library("A", "B", 100);
library.AddDirectory(directory);
library.AddDirectory(directory1);
directory.AddBook(book);
directory.AddBook(book1);
directory1.AddBook(book2);
library.GetDirectory();
directory.GetBooks();
directory1.GetBooks();
library.GetLibraryDetails();

