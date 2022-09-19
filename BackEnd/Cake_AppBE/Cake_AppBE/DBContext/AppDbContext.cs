using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;

namespace Cake_AppBE.DBContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ShapeOfCake> ShapeOfCakes { get; set; }
        public DbSet<SizeOfCake> SizeOfCakes { get; set; }
        public DbSet<CakeTopping> CakeToppings { get; set; }
        public DbSet<CakeWordDesign> CakeWordDesigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(p => new { p.UserName }).IsUnique();
        }

    }
}
