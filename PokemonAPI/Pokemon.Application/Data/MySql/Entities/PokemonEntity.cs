using Pokemon.Application.Contracts.Pokemon.Request;
using Pokemon.Application.Data.MySql.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokemon.Application.Data.MySql.Entities
{
    [Table("pokemon")]
    public class PokemonEntity : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("type")]
        public PokemonType Type { get; set; }

        public PokemonEntity(PokemonPostRequest pokemonRequest) : base()
        {
            Name = pokemonRequest.Name;
            Type = pokemonRequest.Type;
        }

        public PokemonEntity()
        {
        }
    }
}