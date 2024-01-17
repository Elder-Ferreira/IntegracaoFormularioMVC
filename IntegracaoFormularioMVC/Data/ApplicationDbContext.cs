using IntegracaoFormularioMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegracaoFormularioMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        public DbSet<LivrosModel> Livros { get; set; }
    }
}
