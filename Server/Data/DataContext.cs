namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3451,
                    Title = "NTN",
                    Description = "Company",
                    ImageUrl = "https://marvel-b1-cdn.bc0a.com/f00000000229351/ntnamericas.com/wp-content/uploads/2020/03/750031_2.png",
                    Price = 39.99m
                },
            new Product
            {
                Id = 1435,
                Title = "google",
                Description = "Tech Company",
                ImageUrl = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
                Price = 29.99m
            }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
