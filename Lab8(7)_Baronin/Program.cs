using Lab8_7__Baronin;

Library<Book> library = new Library<Book>();

Book book1 = new Book()
{
    Author = "Harper Lee",
    Title = "To Kill a Mockingbird",
};

Book book2 = new Book()
{
    Author = "Harper Lee",
    Title = "Go Set a Watchman ",
};

Book book3 = new Book()
{
    Author = "Doe",
    Title = "John Doe Second edition",
};

Book book4 = new Book()
{
    Author = "Suzanne Collins",
    Title = "Hunger Games: Sunrise on the Reaping",
};

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);

Console.WriteLine("======= All Books =======");
library.PrintAllBooks();

var foundBooksByAuthor = library.FindBooksByAuthor("Doe");
var foundBooksByTitle = library.FindBookByTitle("John Doe Second edition");

Console.WriteLine("=======By Author =======");
foreach (var foundBook in foundBooksByAuthor)
{
    Console.WriteLine(foundBook);
}

Console.WriteLine("=======By Title =======");
foreach (var foundBook in foundBooksByTitle)
{
    Console.WriteLine(foundBook);
}



