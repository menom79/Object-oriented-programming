using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Book book2 = new Book(); 
            book2.title = "Harry Potter";
            book2.author = "JK Rowling";
            book2.pages = 400;

            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }      
    }
}