using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services
{
    public class CharacterService : ICharacterService
    {
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };
    }
}