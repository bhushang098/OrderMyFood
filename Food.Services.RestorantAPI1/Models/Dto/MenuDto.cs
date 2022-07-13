namespace Food.Services.RestorantAPI1.Models.Dto
{
    public class MenuDto
    {
        public int Id { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
