using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_MovieApp
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string LaunchDate { get; set; }
        public decimal BoxOfficeCollection { get; set; }

        public Movie(string title, string genre, string launchDate, decimal boxOfficeCollection)
        {
            Title = title;
            Genre = genre;
            LaunchDate = launchDate;
            BoxOfficeCollection = boxOfficeCollection;
        }
    }
}
