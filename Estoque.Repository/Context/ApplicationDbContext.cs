using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Context
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=EstoqueNeiaPresentes;user=root;password=963258nF@");
        }
        
    }
}
