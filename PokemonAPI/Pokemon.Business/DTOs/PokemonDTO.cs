using Pokemon.Business.Models;
using Pokemon.Business.Models.Enums;
using System;

namespace Pokemon.Business.DTOs
{
    public class PokemonDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public PokemonType Type { get; set; }

        public PokemonDTO(PokemonEntity pokemonEntity)
        {
            Id = pokemonEntity.Id;
            Name = pokemonEntity.Name;
            Type = pokemonEntity.Type;
        }

        public PokemonDTO()
        {  
        }
    }
}
