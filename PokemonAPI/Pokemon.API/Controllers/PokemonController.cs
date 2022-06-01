using Microsoft.AspNetCore.Mvc;
using Pokemon.Business.DTOs;
using Pokemon.Business.Interfaces;
using Pokemon.Business.Models;
using Pokemon.Business.Services;

namespace Pokemon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PokemonController : ControllerBase
    {
        private IPokemonService _service;
        public PokemonController(IPokemonService service)
        {
            _service = service; 
        }


        [HttpPost()]
        public PokemonDTO Create(PokemonDTO pokemonDto)
        {
            return _service.Create(pokemonDto);
        }
    }
}
