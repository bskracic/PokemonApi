using PokemonApi.Dto;

namespace PokemonApi.Services
{
    public class PokemonService : IPokemonService
    {

        private static List<PokemonDto> _pokemons = new()
        {
            new PokemonDto { Id = 1, Name = "Bulbasaur", Type = "Grass" },
            new PokemonDto { Id = 2, Name = "Charmander", Type = "Fire" },
            new PokemonDto { Id = 3, Name = "Squirtle", Type = "Water" },
        };

        public List<PokemonDto> GetAllPokemon()
        {
            return _pokemons;
        }
    }
}
