using static DungeonGuyConsole.Character.CharacterRace;
using static DungeonGuyConsole.Character.CharacterClass;
namespace DungeonGuyConsole.Character
{
    public class Character
    {
        public string Name { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }
        public List<Item> Inventory { get; set; }

        public Character()
        {
            Name = Name;
            Job = new Job();
            Race = new Race();
            Stats = new Stats();
            Inventory = new List<Item>();
        }
    }

    public class Stats
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
    }
}