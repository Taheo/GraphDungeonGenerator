using DungeonAPI.Models;
using QuickGraph;

namespace DungeonAPI.Services
{
    public class DungeonService : IDungeonService
    {
        private readonly GraphDungeonGenerator.Engine _engine;

        public DungeonService(GraphDungeonGenerator.Engine engine)
        {
            _engine = engine;
        }
        public Dungeon GenerateDungeon(int v)
        {
            var result = new Dungeon();
            result.DungeonGraph = _engine.GenerateSimpleGraph(3);
            result.Title = "Awesome Dungeon";

            return result;
        }
    }
}
