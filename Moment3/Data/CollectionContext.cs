using Moment3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Moment3.Data
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options) {
            
        }
        public DbSet<Record> Records { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
