using Microsoft.EntityFrameworkCore;
using MusicasApi.Models;

namespace MusicasApi.Data
{
    public class MusicaContext : DbContext
    {
        //contexto entre aplicação e banco de dados
        public MusicaContext(DbContextOptions<MusicaContext> opts) : base(opts)
        {

        }
        public DbSet<Musica> Musicas { get; set; }
    }
}
