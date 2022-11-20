using ControleOrcamentoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleOrcamentoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {
                    
        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
    }
}
