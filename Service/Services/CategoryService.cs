using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> repository, IMapper mapper, ICategoryRepository categoryRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CustomResponseDto<ProductsByCategory>> GetProductsByCategoryAsync(int categoryId)
        {
            var category = await _categoryRepository.GetProductsByCategoryAsync(categoryId);
            var categoryDto = _mapper.Map<ProductsByCategory>(category);
            return CustomResponseDto<ProductsByCategory>.Success(categoryDto,200);
        }
    }
}
