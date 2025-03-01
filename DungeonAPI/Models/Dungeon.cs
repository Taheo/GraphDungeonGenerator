using QuickGraph;

namespace DungeonAPI.Models
{
    public class Dungeon
    {
        public string Title { get; set; }
        public AdjacencyGraph<int, Edge<int>> DungeonGraph { get; set; }
    }
}
