using Pokemon.Business.DTOs;


namespace Pokemon.Business.Interfaces
{
    public interface IPokemonService
    {
        PokemonDTO Create(PokemonDTO pokemondto);
    }
}
