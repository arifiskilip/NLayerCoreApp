using Core.Entities;

namespace Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetProductsByCategoryAsync(int categoryId);
    }
}
