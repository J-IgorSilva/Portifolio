using Pokemon.Business.DTOs;
using Pokemon.Business.Models.Enums;
using System;

namespace Pokemon.Business.Models
{
    public class PokemonEntity : BaseEntity
    {
        public string Name { get; set; }

        public PokemonType Type { get; set; }

        public PokemonEntity(PokemonDTO pokemonDto) : base()
        {
            Name = pokemonDto.Name;
            Type = pokemonDto.Type;
        }
    }
}
