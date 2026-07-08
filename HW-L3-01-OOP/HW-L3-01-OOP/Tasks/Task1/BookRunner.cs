namespace Tasks.Task1
{
    internal class BookRunner
    {
        public static void Run()
        {
            Book book1 = new Book("Symphony of the Dead", "Abbas Maroufi", "9789643627066");
            Book book2 = new Book("The Blind Owl", "Sadegh Hedayat", "9789644480172");
            Book book3 = new Book("Crime and Punishment", "Fyodor Dostoevsky", "9780140449136");
            Book book4 = new Book("The Death of Ivan Ilyich", "Leo Tolstoy", "9780140449617");
            Book book5 = new Book("The Grapes of Wrath", "John Steinbeck", "9780143039433");

            Library library = new Library(book1 , book2, book3);

            library.AddBook(book4);
            library.AddBook(book5);

            library.BorrowBook("The Blind Owl");
            library.BorrowBook("The Grapes of Wrath");

            library.ReturnBook("The Blind Owl");
        }
    }
}
