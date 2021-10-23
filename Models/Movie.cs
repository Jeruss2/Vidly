using System;
using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        public GenreType GenreType { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }

        public byte ImageId { get; set; }
        public Image Image { get; set; }

    }

    // /movies
}