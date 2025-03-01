namespace DungeonAPI.Services
{
    public class TitleService : ITitleService
    {
        static Random random = new Random();
        public string GenerateTitle()
        {
            List<string> type = new List<string>() {"castle","fortress","cave" };
            List<string> enemies = new List<string>() { "werewolves", "goblins", "undead" };

            return $"{type.OrderBy(_ => random.Next()).First()} of {enemies.OrderBy(_ => random.Next()).First()}";
        }
    }
}
