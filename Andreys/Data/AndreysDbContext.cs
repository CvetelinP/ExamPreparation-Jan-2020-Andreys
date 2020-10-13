using Andreys.Models;

namespace Andreys.Data
{
    using Microsoft.EntityFrameworkCore;

    public class AndreysDbContext : DbContext
    {
        public AndreysDbContext()
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Test;Integrated Security=true;");
        }
    }
}
