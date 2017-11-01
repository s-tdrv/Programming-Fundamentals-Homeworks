namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

    }

    public class StartUp
    {
        public static void Main()
        {
            Library library = new Library
            {
                Name = "",
                Books = new List<Book>()
            };


            var input = File.ReadAllLines("input.txt");
            int bookCounter = int.Parse(input[0]);
            for (int i = 1; i <= bookCounter; i++)
            {
                string[] bookArgs = input[i]
                    .Split(' ').ToArray();

                Book currentBook = new Book
                {
                    Title = bookArgs[0],
                    Author = bookArgs[1],
                    Publisher = bookArgs[2],
                    ReleaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = bookArgs[4],
                    Price = decimal.Parse(bookArgs[5])
                };

                library.Books.Add(currentBook);
            }
            var release = DateTime.ParseExact(input[bookCounter + 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var output = library.Books
                .Where(book => book.ReleaseDate > release)
                .OrderBy(book => book.ReleaseDate)
                .ThenBy(book => book.Title)
                .Select(book => $"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}")
                .ToList();
            File.WriteAllLines("output.txt", output);
        }
    }
}
