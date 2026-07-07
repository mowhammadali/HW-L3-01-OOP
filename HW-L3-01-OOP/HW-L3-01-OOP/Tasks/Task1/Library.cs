namespace Tasks.Task1
{
    internal class Library
    {
        public List<Book> books { get; private set; }

        public Library()
        {
            books = new List<Book>();
        }

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void BorrowBook(string title)
        {
            Book? book = books.Find(b => b.Title == title);

            if (book == null)
            {
                Console.WriteLine("This book does not exist in the library.");
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine("This book has already been borrowed.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine($"The {book.Title} has been borrowed successfully.");
        }

        public void ReturnBook(string title)
        {
            Book? book = books.Find(b => b.Title == title);

            if (book != null)
            {
                book.IsAvailable = true;
                Console.WriteLine($"The {book.Title} has been returned successfully.");
            }
        }
    }
}
