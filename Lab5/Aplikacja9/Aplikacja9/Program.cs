using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw9
{
    class Book
    {
       

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }

        public string ISBN { get; }

        public Book(string isbn)
        {
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Book \"{Title}\" by {Author}\n"
                + $"   Price: {Price:0.00}, Date: {Date.ToShortDateString()}\n"
                + $"   ISBN: {ISBN}";
        }
    }

    static class Library
    {
        static Library()
        {
            Console.WriteLine("Library is created... \n");
        }

        private static readonly Dictionary<string, Book> booksDictionary = new();

        public static IEnumerable<Book> GetAllBooks() => booksDictionary.Values;

        public static void AddBook(Book book)
        {
            if (booksDictionary.ContainsKey(book.ISBN))
                throw new Exception($"Fail. Book with ISBN {book.ISBN} already exists!");

            booksDictionary.Add(book.ISBN, book);
        }

        public static Book RemoveBook(string isbn)
        {
            booksDictionary.Remove(isbn, out var book);
            return book;
        }
        public static bool RemoveBook(Book book) => booksDictionary.Remove(book.ISBN);

        public static void UpdateBook(Book book)
        {
            if (!booksDictionary.ContainsKey(book.ISBN))
                throw new Exception($"Fail. The ISBN: {book.ISBN} does not exist in that library");
            booksDictionary[book.ISBN] = book;
        }

        public static Book FindByISBN(string isbn) => booksDictionary[isbn];

        public static Book FindByTitle(string title) => FindByPredicate(book => book.Title == title);
        public static Book FindByAuthor(string author) => FindByPredicate(book => book.Author == author);
        public static Book FindByPrice(double price) =>
            // bezpośrednie porównywanie doubli to może być zły pomysł (floating point error)
            FindByPredicate(book => Math.Abs(book.Price - price) < 0.001);

        public static Book FindByPredicate(Func<Book, bool> predicate) =>
            booksDictionary.Values.FirstOrDefault(predicate);

        // https://stackoverflow.com/questions/278390/how-do-you-override-tostring-in-a-static-class
        public new static string ToString()
        {
            if (booksDictionary.Count == 0)
                return "The library is empty.\n";

            var sb = new StringBuilder();
            sb.AppendLine("Library contains following books:");
            foreach (var book in GetAllBooks())
                sb.AppendLine($" - {book}");
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Library.ToString());

            var book1 = new Book("001");
            book1.Title = "Wprowadzenie do majzy";
            book1.Author = "Thomas H. Cormen";
            book1.Price = 150;
            book1.Date = new DateTime(2012, 5, 10);

            var book2 = new Book("002");
            book2.Title = "Hihi";
            book2.Author = "K.Baradziej";
            book2.Price = 10000;
            book2.Date = new DateTime(2020, 11, 29);

            Console.WriteLine("Adding books:");
            Library.AddBook(book1);
            Library.AddBook(book2);
            Console.WriteLine(Library.ToString());

            Library.AddBook(book1);
 
            Console.WriteLine("Finding book by author:");
            var found = Library.FindByAuthor("Thomas H. Cormen");
            Console.WriteLine(found);

            Console.WriteLine("\nUpdating book date and saving back.");
            found.Date = new DateTime(2012, 5, 23);
            Library.UpdateBook(found);

            Console.WriteLine(Library.ToString());

            Console.WriteLine("Book ISBN -> deleting:");
            var deleted = Library.RemoveBook("002");
            Console.WriteLine("Deleted book:\n" + deleted);

            Console.WriteLine("\n" + Library.ToString());
            Console.ReadKey();
        }
    }
}
