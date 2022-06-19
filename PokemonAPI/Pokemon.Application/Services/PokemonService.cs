using Pokemon.Application.Contracts.Pokemon.Request;
using Pokemon.Application.Contracts.Pokemon.Response;
using Pokemon.Application.Data.MySql.Entities;
using Pokemon.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokemon.Application.Services
{
    public class PokemonService
    {
        private readonly PokemonRepository _pokemonRepository;

        public PokemonService(PokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<List<PokemonPostResponse>> GetAllAsync()
        {
            var entityList = await _pokemonRepository.GetAll();
            var responseList = new List<PokemonPostResponse>();

            foreach (var entity in entityList)
            {
                responseList.Add(new PokemonPostResponse(entity));
            }

            return responseList;
        }


        public async Task<PokemonPostResponse> CreateAsync(PokemonPostRequest pokemonRequest)
        {
            var entity = new PokemonEntity(pokemonRequest);
            await _pokemonRepository.Create(entity);
            var pokemonResponse = new PokemonPostResponse(entity);

            return pokemonResponse;
        }
    }
}