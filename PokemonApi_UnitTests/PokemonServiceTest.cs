using PokemonApi.Services;

namespace PokemonApi_UnitTests
{
    public class PokemonServiceTest
    {
        [Fact]
        public void GetAllPokemon_ShouldReturnNonEmptyList()
        {
            //Arrange
            PokemonService sut = new();
            // Act
            var pokemons = sut.GetAllPokemon();
            // Assert
            Assert.NotEmpty(pokemons);
        }
    }
}