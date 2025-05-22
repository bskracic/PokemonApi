using PokemonApi.Dto;

namespace PokemonApi.Services
{
    public interface IPokemonService
    {
        public List<PokemonDto> GetAllPokemon(); 
    }
}
