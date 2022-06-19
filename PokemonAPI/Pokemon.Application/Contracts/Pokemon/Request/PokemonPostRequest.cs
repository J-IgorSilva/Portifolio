using Pokemon.Application.Data.MySql.Entities;
using Pokemon.Application.Data.MySql.Entities.Enums;
using System;

namespace Pokemon.Application.Contracts.Pokemon.Request
{
    public class PokemonPostRequest
    {
        public string Name { get; set; }

        public PokemonType Type { get; set; }

        public PokemonPostRequest(PokemonEntity pokemonEntity)
        {
            Name = pokemonEntity.Name;
            Type = pokemonEntity.Type;
        }

        public PokemonPostRequest()
        {
        }
    }
}