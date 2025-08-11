using Microsoft.EntityFrameworkCore;
using app_tarefas.Models;

namespace app_tarefas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tipo> Tipos { get; set; } = null!;
    }
}
