namespace DungeonAPI.Services
{
    public class TitleService : ITitleService
    {
        public string GenerateTitle()
        {
            List<string> type = new List<string>() {"castle","fortress","cave" };
            List<string> enemies = new List<string>() { "werewolves", "goblins", "undead" };
            string result = string.Empty;
            return result;
        }
    }
}
