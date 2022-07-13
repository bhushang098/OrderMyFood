using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web.Models
{
    public class RestorantDto
    {
        
        public int RestorantId { get; set; }
     
        public string Location { get; set; }

        public string Name { get; set; }

        public int MenuId { get; set; }

        public string Cuisine { get; set; }

        public double Rating { get; set; }

        public int Distance { get; set; }

        public string ImageUrl { get; set; }

    
    }
}
