using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.ViewModels.Movie
{
    public class InputMovieViewModel
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [OldMovie(1900)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}