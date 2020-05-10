using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Services;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        private static Character rogue = new Character();

        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}