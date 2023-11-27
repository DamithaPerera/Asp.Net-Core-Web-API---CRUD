using Microsoft.EntityFrameworkCore;
using NSWalksAPI.Models.Domain;

namespace NSWalksAPI.Data
{
    public class NZWalksDBcontext: DbContext
    {
        public NZWalksDBcontext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
            
        }

        public DbSet<Difficulty> Diffiulties { get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<Walk> Walkes { get; set; }

    }
}
