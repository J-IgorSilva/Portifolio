using Microsoft.EntityFrameworkCore;
using System;
using Pokemon.Business.Models;

namespace Pokemon.Data
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
