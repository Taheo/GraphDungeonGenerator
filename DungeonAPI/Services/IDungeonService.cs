using DungeonAPI.Models;

namespace DungeonAPI.Services
{
    public interface IDungeonService
    {
        public Dungeon GenerateDungeon(int v);
    }
}
