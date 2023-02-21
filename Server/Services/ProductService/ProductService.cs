namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var reponse = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                reponse.Success= false;
                reponse.Message = "This item does not exist";
            }
            else
            {
                reponse.Data = product;
            }
            return reponse;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsyncs()
        {
            var reponse = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return reponse;
        }
    }
}
