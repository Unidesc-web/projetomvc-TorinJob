using Microsoft.EntityFrameworkCore;
using LanchoneteMVC.Models;

namespace LanchoneteMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}