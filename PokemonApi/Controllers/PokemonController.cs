using Microsoft.AspNetCore.Mvc;
using PokemonApi.Dto;
using PokemonApi.Services;

namespace PokemonApi.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public ActionResult<List<PokemonDto>> Get()
        {
            return Ok(_pokemonService.GetAllPokemon());
        }

        [HttpGet("search")]
        public ActionResult<List<PokemonDto>> Search(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("type must be a string!");

            return Ok(_pokemonService
                .GetAllPokemon()
                .Where(p => string.Equals(p.Type, type, StringComparison.OrdinalIgnoreCase))
                .ToList());
        }
    }
}
