﻿using Core.DTOs;
using Core.Entities;

namespace Core.Services
{
    public interface IProductService :IService<Product>
    {
        Task<CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategoryAsync();
    }
}
