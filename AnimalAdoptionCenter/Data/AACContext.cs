using AnimalAdoptionCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalAdoptionCenter.Data
{
    public class AACContext : DbContext
    {
        public AACContext(DbContextOptions<AACContext> options) : base(options)
        {
        }
        public virtual DbSet<Animal>? Animals { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<SubCategory>? SubCategories { get; set; }
        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<City>? Cities { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dog"},
                new Category { Id = 2, Name = "Cat" });
        }
    }
}
