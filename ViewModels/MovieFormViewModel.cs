using CobaMVCNetFramework.Models;
using System.Collections.Generic;

namespace CobaMVCNetFramework.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}