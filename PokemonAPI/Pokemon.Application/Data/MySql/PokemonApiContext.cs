using Microsoft.EntityFrameworkCore;
using Pokemon.Application.Data.MySql.Entities;

namespace Pokemon.Application.Data.MySql
{
    public class PokemonApiContext : DbContext
    {
        public DbSet<PokemonEntity> Pokemons { get; set; }

        public PokemonApiContext()
        {
        }

        public PokemonApiContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => base.OnModelCreating(modelBuilder);
    }
}