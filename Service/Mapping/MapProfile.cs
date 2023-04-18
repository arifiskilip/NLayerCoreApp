using AutoMapper;
using Core.DTOs;
using Core.Entities;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductsWithCategoryDto>();
            CreateMap<Category, ProductsByCategory>();
        }
    }
}
