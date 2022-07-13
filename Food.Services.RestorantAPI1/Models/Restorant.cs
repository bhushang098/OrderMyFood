using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI.Models
{
    public class Restorant
    {
        [Key]
        public int RestorantId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,1000)]

        public string Location { get; set; }

        public int MenuId { get; set; }
        [ForeignKey("MenuId")]

        public string Cuisine { get; set; }

        public double Rating { get; set; }

        public int Distance { get; set; }   

        public string ImageUrl { get; set; }

       
    }
}
