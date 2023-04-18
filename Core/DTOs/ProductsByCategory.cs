namespace Core.DTOs
{
    public class ProductsByCategory : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
