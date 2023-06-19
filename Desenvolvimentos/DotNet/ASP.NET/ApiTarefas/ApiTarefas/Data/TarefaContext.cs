using ApiTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Data
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> opts) : base(opts)
        {

        }
        public DbSet<Tarefas> Tarefa { get; set; }
    }
}
