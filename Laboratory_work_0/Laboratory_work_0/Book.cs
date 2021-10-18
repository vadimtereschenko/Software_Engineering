using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_0
{
    public class Book
    {
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public int NumOfPages { get; set; }
        public Book() { }
        public Book(string author, int releaseYear, int numOfPages) 
        {
            Author = author;
            ReleaseYear = releaseYear;
            NumOfPages = numOfPages;
        }
    }
}
