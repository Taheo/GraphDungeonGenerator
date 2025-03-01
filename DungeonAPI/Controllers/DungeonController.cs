using DungeonAPI.Enums;
using DungeonAPI.Models;
using DungeonAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DungeonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DungeonController : ControllerBase
    {
        private readonly IDungeonService _dungeonService;

        public DungeonController(IDungeonService dungeonService)
        {
            _dungeonService = dungeonService;
        }

        [HttpGet]
        public ActionResult<Dungeon> GetSimpleDungeon(int verticies, GraphGenerationMethod method)
        {
            var dungeon = _dungeonService.GenerateDungeon(verticies, method);
            if (dungeon == null)
            {
                return NotFound();
            }
            return dungeon;
        }
    }
}
