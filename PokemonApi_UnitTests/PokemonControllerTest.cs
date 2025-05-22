using Microsoft.AspNetCore.Mvc;
using Moq;
using PokemonApi.Controllers;
using PokemonApi.Dto;
using PokemonApi.Services;

namespace PokemonApi_UnitTests
{
    public class PokemonControllerTest
    {

        // Test Context
        private readonly Mock<IPokemonService> _mockPokemonService;
        private readonly PokemonController _controller;

        public PokemonControllerTest()
        {
            _mockPokemonService = new Mock<IPokemonService>();
            _mockPokemonService.Setup(s => s.GetAllPokemon()).Returns(new List<PokemonDto>()
            {
                new PokemonDto {Id = 1, Name = "test", Type = "water"}
            });

            _controller = new PokemonController(_mockPokemonService.Object);
        }



        [Fact]
        public void Get_ShouldReturnOK()
        {
            // Act
            ActionResult<List<PokemonDto>> response = _controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(response.Result);
            Assert.Equal(200, okResult.StatusCode);
        }


        [Fact]
        public void Search_ShouldThrowIfTypeIsEmpty()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _controller.Search(null));
        }

    }
}
