namespace Lab8_7__Baronin
{
    public class Library<T>
    {
        private List<T> _books = new List<T>();

        public void AddBook(T book)
        {
            _books.Add(book);
        }

        public bool RemoveBook(T book)
        {
            return _books.Remove(book);
        }

        public List<T> FindBooksByAuthor(string author)
        {
            List<T> books = new List<T>();

            foreach (dynamic book in _books)
            {
                if (book.Author == author)
                {
                    books.Add(book);
                }
            }

            return books;
        }

        public List<T> FindBookByTitle(string title)
        {
            List<T> books = new List<T>();

            foreach (dynamic book in _books)
            {
                if (book.Title == title)
                {
                    books.Add(book);
                }
            }

            return books;
        }

        public void PrintAllBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}


