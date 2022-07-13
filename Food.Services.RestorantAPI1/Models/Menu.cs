using System.ComponentModel.DataAnnotations;

namespace Food.Services.RestorantAPI1.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        public IEnumerable<Product> Products { get; set; }

        
    }
}
