using AnimalAdoptionCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalAdoptionCenter.Data
{
    public class AnimalAdoptionCenterContext : DbContext
    {
        public AnimalAdoptionCenterContext(DbContextOptions<AnimalAdoptionCenterContext> options) : base(options)
        {
        }
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<SubCategory>? SubCategories { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new { CategoryId = 1, CategoryName = "Dog" },
                new { CategoryId = 2, CategoryName = "Cat" });
        }
    }
}
