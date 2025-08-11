using Microsoft.EntityFrameworkCore;
using app_tarefas.Models;

namespace app_tarefas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tipo> Tipos { get; set; } = null!;
    }
}
