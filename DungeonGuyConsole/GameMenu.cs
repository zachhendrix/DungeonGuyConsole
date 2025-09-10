using Data.Character;
namespace DungeonGuyConsole
{
    public static class GameMenu
    {
        public static void Initialize()
        {
            Dungeon.Initialize();
            GameMenuText();
        }

        public static void GameMenuText()
        {
            Console.WriteLine("Welcome to the Dungeon, guy!");
            Dungeon.DrawMap();
        }
    }
}
