using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Lambda_Expression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        { 
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5 },
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }

    public class Book
    {
        public string Title { get; internal set; }
        public int Price { get; internal set; }
    }
}
