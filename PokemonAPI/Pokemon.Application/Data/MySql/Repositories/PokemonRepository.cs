using Pokemon.Application.Data.MySql;
using Pokemon.Application.Data.MySql.Entities;

namespace Pokemon.Data.Repositories
{
    public class PokemonRepository : BaseRepository<PokemonEntity>
    {
        public PokemonRepository(PokemonApiContext db) : base(db)
        {
        }
    }
}