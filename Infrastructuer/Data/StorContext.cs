using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Infrastructuer.Data
{
    public class StorContext : DbContext
    {
        public StorContext(DbContextOptions<StorContext> options) : base(options)
        {
            
        }
        public DbSet<prodect> prodect { get; set; }
    }
}