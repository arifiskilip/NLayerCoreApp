using Core.Entities;

namespace Core.DTOs
{
    public class ProductsWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
