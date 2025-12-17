using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Context
{
    public class EstoqueDbContext : DbContext
    {
        // Atribustos //
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }

        // Métodos //
        public EstoqueDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=EstoqueNeiaPresentes;user=root;password=963258nF@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EstoqueDbContext).Assembly);
        }

    }
}
