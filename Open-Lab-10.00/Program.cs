using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    public class Book
    {
        private int pages;
        private string title;
        private string cathegory;
        private string author;
        private int releaseDate;

        public void GetTitle() { title = "Madam"; }
        public void GetPages() { pages = 85; }
        public void GetCathegory() { cathegory = "Fanatsy"; }
        public void GetAuthor() { author = "Hanna Suchá"; }
        public void GetReleaseDate() { releaseDate = 2019;

            
        }
        public void WriteVariables()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(cathegory);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.GetTitle();
            LOTR.GetPages();
            LOTR.GetCathegory();
            LOTR.GetAuthor();
            LOTR.GetReleaseDate();
            LOTR.WriteVariables();
            
        }
        
    }
    
}
