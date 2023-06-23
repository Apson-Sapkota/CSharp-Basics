using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book();
            Book1.Title = "Harry Potter";
            
            
            Console.Write(Book1.Title);

            Book Book2 = new Book();
            Console.ReadLine();
        }
    }
}
