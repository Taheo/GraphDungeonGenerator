using DungeonAPI.Models;

namespace DungeonAPI.Services
{
    public class DungeonService : IDungeonService
    {
        private readonly GraphDungeonGenerator.Engine _engine;
        private readonly ITitleService _titleService;

        public DungeonService(GraphDungeonGenerator.Engine engine, ITitleService titleService)
        {
            _engine = engine;
            _titleService = titleService;
        }
        public Dungeon GenerateDungeon(int verticies)
        {
            var result = new Dungeon();
            result.DungeonGraph = _engine.GenerateSimpleGraph(verticies);
            result.Title = _titleService.GenerateTitle();

            return result;
        }
    }
}
