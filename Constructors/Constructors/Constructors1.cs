using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Constructors1
    {
        public string Title;
        public int Pages;
        public string Author;

        public Constructors1(string aTitle,int aPages,string aAuthor)
        {
            Title = aTitle;
            Pages = aPages;
            Author = aAuthor;
        }
    }
}
