using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class library
    {
        private string LibraryName;
        private List<miniProject> books;

        public library(string LibraryName)
        {
            this.LibraryName = LibraryName;
            books = new List<miniProject>();
        }
        public void AddBook(miniProject book)
        {
            books.Add(book);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Library Name:{LibraryName}");
            Console.WriteLine("books:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}
