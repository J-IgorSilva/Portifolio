using Pokemon.Application.Data.MySql.Entities;
using Pokemon.Application.Data.MySql.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Pokemon.Application.Contracts.Pokemon.Response
{
    public class PokemonPostResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public PokemonType Type { get; set; }

        public PokemonPostResponse(PokemonEntity pokemonEntity)
        {
            Id = pokemonEntity.Id;
            Name = pokemonEntity.Name;
            Type = pokemonEntity.Type;
        }

        public PokemonPostResponse()
        {
        }
    }
}