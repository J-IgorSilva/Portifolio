using Microsoft.AspNetCore.Mvc;
using Pokemon.Application.Contracts.Pokemon.Request;
using Pokemon.Application.Services;
using System.Threading.Tasks;

namespace Pokemon.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonService _service;

        public PokemonController(PokemonService service)
        {
            _service = service;
        }

        [HttpPost()]
        public async Task<ActionResult> Create(PokemonPostRequest pokemonPostRequest)
        {
            var pokemonPostResponse = await _service.CreateAsync(pokemonPostRequest);
            return Ok(pokemonPostResponse);
        }

        [HttpGet()]
        public async Task<ActionResult> GetAll()
        {
            var pokemonPostResponseList = await _service.GetAllAsync();
            return Ok(pokemonPostResponseList);
        }
    }
}