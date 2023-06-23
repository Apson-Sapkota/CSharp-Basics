using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructors1 Book1 = new Constructors1("Harry Potter",222,"Jk Rolling");
            Console.WriteLine(Book1.Title);
            Console.ReadLine();
        }
    }
}
