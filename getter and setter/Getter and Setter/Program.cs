using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_and_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie Movie1 = new Movie("Harry Potter","JK Rolling",223,"G");
            Console.WriteLine(Movie1.Rating);
            Console.ReadLine();
        }
    }
}
