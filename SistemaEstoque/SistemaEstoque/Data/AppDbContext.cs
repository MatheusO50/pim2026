using Microsoft.EntityFrameworkCore;
using SistemaEstoque.Models;

namespace SistemaEstoque.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Peca> Pecas { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
