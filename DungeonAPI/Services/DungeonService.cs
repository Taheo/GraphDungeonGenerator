using DungeonAPI.Enums;
using DungeonAPI.Models;
using GraphDungeonGenerator;

namespace DungeonAPI.Services
{
    public class DungeonService : IDungeonService
    {
        private readonly Engine _engine;
        private readonly ITitleService _titleService;

        public DungeonService(Engine engine, ITitleService titleService)
        {
            _engine = engine;
            _titleService = titleService;
        }
        public Dungeon GenerateDungeon(int verticies, GraphGenerationMethod method)
        {
            var result = new Dungeon();
            switch (method)
            {
                case GraphGenerationMethod.Simple:
                    result.DungeonGraph = _engine.GenerateSimpleGraph(verticies);
                    break;
                case GraphGenerationMethod.RandomOneEntrance:
                    result.DungeonGraph = _engine.GenerateRandomGraphWithOneEntrance(verticies);
                    break;
                default:
                    throw new ArgumentException("Unknown graph generation method.");
            }

            result.Title = _titleService.GenerateTitle();

            return result;
        }
    }
}
