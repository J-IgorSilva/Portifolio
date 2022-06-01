using Pokemon.Business.DTOs;
using Pokemon.Business.Interfaces;
using Pokemon.Business.Models;

namespace Pokemon.Business.Services
{
    public class PokemonService : IPokemonService
    {
        public PokemonDTO Create(PokemonDTO pokemonDto)
        {
            PokemonEntity brabo = new PokemonEntity(pokemonDto);
            return  new PokemonDTO(brabo);
        }
    }
}
