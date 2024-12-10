using BackEndApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEndApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                   new Brand { Id = 1, Name = "Toyota" },
                   new Brand { Id = 2, Name = "Honda" },
                   new Brand { Id = 3, Name = "Ford" }
            );
        }
    }
}
