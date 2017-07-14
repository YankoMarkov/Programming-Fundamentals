using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public double Price { get; set; }
    public string ISBNNumber { get; set; }
    public DateTime ReleaseDate { get; set; }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class BookLibrary
{
    static void Main(string[] args)
    {
        var books = AddToLibrary();
        var autors = AutorTotalPrice(books);
        autors = autors.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in autors)
        {
            Console.WriteLine($"{item.Key} -> {item.Value:f2}");
        }
    }

    private static Dictionary<string, double> AutorTotalPrice(List<Book> books)
    {
        var result = new Dictionary<string, double>();
        foreach (var item in books)
        {
            if (!result.ContainsKey(item.Author))
            {
                result.Add(item.Author, 0);
            }
            result[item.Author] += item.Price;
        }
        return result;
    }

    private static Book ReadBook()
    {
        var book = new Book();
        var input = Console.ReadLine().Split().ToArray();
        book.Title = input[0];
        book.Author = input[1];
        book.Publisher = input[2];
        book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
        book.ISBNNumber = input[4];
        book.Price = double.Parse(input[5]);
        return book;
    }

    private static List<Book> AddToLibrary()
    {
        var num = int.Parse(Console.ReadLine());
        var libraray = new Library();
        libraray.Books = new List<Book>();
        for (int i = 0; i < num; i++)
        {
            var book = ReadBook();
            libraray.Books.Add(book);
        }
        return libraray.Books;
    }
}

