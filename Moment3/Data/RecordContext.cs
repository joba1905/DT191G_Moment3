using Moment3.Models;
using Microsoft.EntityFrameworkCore;

namespace Moment3.Data
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options) {
            
        }

        public DbSet<Record> Record { get; set; }
    }
}
