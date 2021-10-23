using System.Collections.Generic;
using vidly.Models;

namespace vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<GenreType> GenreTypes { get; set; }
        public IEnumerable<Image> Images { get; set; }

        //Added Images here

    }
}