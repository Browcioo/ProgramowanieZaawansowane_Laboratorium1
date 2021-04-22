using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramowanieZaawansowane_Laboratorium1.Models
{
    public class Shopping
    {
        
        public int ID { get; set; }
        
        public string Title { get; set; }

        [DataType(DataType.Date)]
        
        public DateTime ReleaseDate { get; set; }
        
        public decimal Price { get; set; }
    }
}
