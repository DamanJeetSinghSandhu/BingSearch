using Bing.Models;
using Microsoft.EntityFrameworkCore;


namespace Bing.Db
{
    public class BingDbContext:DbContext
    {
        public DbSet<Location> Location { get; set; }

       

        public BingDbContext(DbContextOptions<BingDbContext> options) : base(options)
        {
        }
    }
}
