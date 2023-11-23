using Microsoft.EntityFrameworkCore;

namespace WebApplication1.models
{
    public class BrandContext: DbContext
    {
        // constructure
        public BrandContext(DbContextOptions<BrandContext> options) : base(options) { 

        }

        public DbSet<Brand> Brands { get; set; }
    }
}
