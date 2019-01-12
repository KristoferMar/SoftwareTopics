using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.LINQ
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var books = new BookRepository().GetBooks();

        //    //This is how we do it without linq
        //    //var cheapBooks = new List<Book>();
        //    //foreach(var book in books)
        //    //{
        //    //    if (book.Price < 10)
        //    //        cheapBooks.Add(book);
        //    //}

        //    //LINQ query operators
        //    var cheaperBooks2 = from b in books
        //                        where b.Price < 10
        //                        orderby b.Title
        //                        select b.Title;

        //    //This is how we do it using LINQ + a lambda expression. + we sort by title + we convert our object to list of strings becuase we select b.Title. 
        //    //"Select" converts our object to a list of something fx a string.
        //    //LINQ extension methods
        //    var cheapBooks = books
        //        .Where(b => b.Price < 10)
        //        .OrderBy(b => b.Title)
        //        .Select(b => b.Title);

        //    //LINQ methods.
        //    var book1 = books.Single(b => b.Title == "ASP.NET MVC");//Returns only one object.
        //    var book2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); //Returns null if name not found

        //    var book3 = books.First(b => b.Title == "ASP.NET MVC"); //Gives first in list
        //    var book4 = books.FirstOrDefault(b => b.Title == "ASP.NET MVC"); //Returns null if name not found

        //    var book5 = books.Last(b => b.Title == "ASP.NET MVC"); //Gives first in list
        //    var book6 = books.LastOrDefault(b => b.Title == "ASP.NET MVC"); //Returns null if name not found

        //    var book7 = books.Skip(2).Take(3); //Skips first two in list takes the next three.

        //    var book8 = books.Max(b => b.Price); //Maximum price
        //    var book9 = books.Min(b => b.Price); //Minimum Price

        //    var book10 = books.Sum(b => b.Price); //Sum


        //    foreach (var book in cheapBooks)
        //        Console.WriteLine(book);

        //    Console.ReadLine();
        //}
    }
}
