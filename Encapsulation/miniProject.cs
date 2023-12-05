using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class miniProject
    {
        private string title;
        private string Author;
        private int PageCount;

        public miniProject(string name,string writer,int page)
        {
            this.title = name;
            Author = writer;
            PageCount = page;

        }

        public string getTitle()
        {
            return title;
        }
        public string getauthor()
        {
            return Author;
        }
        public int getpage()
        {
            return PageCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title:{title},Author:{Author},Page Count:{PageCount}");
        }
    }
}
