using System;

namespace Getter_and_Setter
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        private string rating;

        public Movie(string title, string author, int pages, string rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "GR")
                {
                    rating = value;
                }
                else { rating = "NR"; }
            }
        }
    }
}
