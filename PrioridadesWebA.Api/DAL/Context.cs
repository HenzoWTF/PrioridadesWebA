using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace PrioridadesWebA.Api.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Sistemas> Sistema { get; set; }
    }
}
