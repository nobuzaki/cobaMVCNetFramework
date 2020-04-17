using System;
using System.ComponentModel.DataAnnotations;

namespace CobaMVCNetFramework.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }
    }
}