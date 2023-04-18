using Core.DTOs;
using Core.Entities;

namespace Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<ProductsByCategory>> GetProductsByCategoryAsync(int categoryId);
    }
}
