using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Context
{
    public class EstoqueDbContext : DbContext
    {
        // Atribustos //
        public DbSet<User> Users { get; set; }

        // Métodos //
        public EstoqueDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=EstoqueNeiaPresentes;user=root;password=963258nF@");
        }
        
    }
}
