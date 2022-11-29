using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EntregaAgua.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) :base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }

    }
}
