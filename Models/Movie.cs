using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CobaMVCNetFramework.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }
    }
}