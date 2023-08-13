using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<Blog> Blog { get; set; }

        // Configure any additional entities here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity relationships and constraints here
        }
    }
}