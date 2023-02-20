namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductAsyncs()
        {
            var reponse = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return reponse;
        }
    }
}
