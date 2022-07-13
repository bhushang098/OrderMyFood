namespace Mango.Web.Models
{
    public class MenuDto
    {
        public int Id { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
    }
}
