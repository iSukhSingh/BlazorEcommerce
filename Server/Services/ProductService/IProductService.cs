﻿namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsyncs();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
