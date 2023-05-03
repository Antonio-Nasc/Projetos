using CarrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrosApi.Data
{
    public class CarrosContext : DbContext
    {
        public CarrosContext(DbContextOptions<CarrosContext> opts) : base(opts)
        {
            
        }
        public DbSet<Carro> Carros { get; set; }
    }
}
