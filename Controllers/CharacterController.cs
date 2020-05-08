using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character rogue = new Character();

        public IActionResult Get()
        {
            return Ok(rogue);
        }
    }
}