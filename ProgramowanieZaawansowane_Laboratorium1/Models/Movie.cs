using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramowanieZaawansowane_Laboratorium1.Models
{
    public class Movie
    {
        [Display(Name = "Identyfikator")]
        public int ID { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data wypuszczenia")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek filmu")]
        public string Genre { get; set; }
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
