using System;
using System.ComponentModel.DataAnnotations;

namespace CobaMVCNetFramework.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}