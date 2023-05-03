using EstadoApi.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace EstadoApi.Data
{
    public class EstadoContext : DbContext
    {
        public EstadoContext(DbContextOptions<EstadoContext> opts) : base(opts)
        {
            
        }

        public DbSet<Estado> Estados { get; set; }
    }
}
