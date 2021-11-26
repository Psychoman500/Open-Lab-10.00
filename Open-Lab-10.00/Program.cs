using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    class Book
    {
        private int pages;
        public string title;
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "Madam";
            Console.WriteLine(LOTR.title);
        }
    }
    
}
