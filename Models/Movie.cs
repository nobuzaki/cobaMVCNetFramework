using System;
using System.ComponentModel.DataAnnotations;

namespace CobaMVCNetFramework.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

       // [Required]
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        //[Required]
        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [MaxNumberInStock]
        public int Stock { get; set; }
    }
}