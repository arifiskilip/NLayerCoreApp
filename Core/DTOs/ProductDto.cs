namespace Core.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
