using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Lambda_Expression
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //This is how we can iterrate through books without using lambda expression
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            //This is how we would do it with Lambda Expression
            var cheapBooksLambda = books.FindAll(b => b.Price < 10);

            foreach(var book in cheapBooksLambda)
            {
                Console.WriteLine(book.Title);
            }



            //Same task solved with lambda expression using generic Func
            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine(squareLambda(5));

            //One way to area of square without lambda expression.
            Console.WriteLine(Square(5));
            Console.ReadLine();
        }

        //Example method - we can avoid it.
        static int Square(int number)
        {
            return number * number;
        }

        //Example method - We can avoid it.
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
