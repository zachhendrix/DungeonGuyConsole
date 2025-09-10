namespace Data.Character
{
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Halfling,
        Gnome,
        HalfElf,
        HalfOrc,
        Orc,
        Goblin,
        Troll,
        Undead,
        Vampire,
        Werewolf,
        Fairy,
        Golem,
        Plantfolk,
        Robot,
        Alien,
        Clown
    }

    public class RaceData
    {
        public string Name;
        public Stats Stats;

        public RaceData(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }
    }

    public static class RaceDatabase
    {
        private static readonly Dictionary<Race, RaceData> _raceData = new()
        {
            {Race.Human,     new RaceData("Human",     new Stats(100, 50, 70, 12, 12, 10, 10, 10, 10))},
            {Race.Elf,       new RaceData("Elf",       new Stats(80, 80, 50,  8, 14,  8, 14, 10, 10))},
            {Race.Dwarf,     new RaceData("Dwarf",     new Stats(130, 30, 80, 12,  8, 12,  8, 12, 12))},
            {Race.Halfling,  new RaceData("Halfling",  new Stats( 60, 40, 110,  6, 16,  8, 10, 12, 12))},
            {Race.Gnome,     new RaceData("Gnome",     new Stats( 70, 70, 70,  8, 10, 10, 12, 12, 12))},
            {Race.HalfElf,   new RaceData("Half-Elf",  new Stats( 90, 60, 70, 10, 10, 10, 10, 12, 12))},
            {Race.HalfOrc,   new RaceData("Half-Orc",  new Stats(120, 30, 90, 14,  8, 12,  8, 10, 12))},
            {Race.Orc,       new RaceData("Orc",       new Stats(140, 20, 80, 14,  8, 12,  8, 10, 12))},
            {Race.Goblin,    new RaceData("Goblin",    new Stats(60, 30, 110,  8, 12,  8, 10, 10, 16))},
            {Race.Troll,     new RaceData("Troll",     new Stats(150, 20, 70, 16,  6, 14,  6, 10, 12))},
            {Race.Undead,    new RaceData("Undead",    new Stats(100, 50, 70, 10, 10, 10, 12, 10, 12))},
            {Race.Vampire,   new RaceData("Vampire",   new Stats(90, 80, 50, 10, 12, 10, 12, 10, 10))},
            {Race.Werewolf,  new RaceData("Werewolf",  new Stats(130, 30, 80, 14, 10, 12,  8, 10, 10))},
            {Race.Fairy,     new RaceData("Fairy",     new Stats(70, 80, 60,  6, 16,  6, 16, 10, 10))},
            {Race.Golem,     new RaceData("Golem",     new Stats( 160, 20, 60, 16,  6, 14,  6, 10, 12))},
            {Race.Plantfolk, new RaceData("Plantfolk", new Stats(110, 40, 70, 10,  8, 12, 12, 10, 12))},
            {Race.Robot,     new RaceData("Robot",     new Stats(130, 30, 80, 14,  8, 14, 10,  8, 10))},
            {Race.Alien,     new RaceData("Alien",     new Stats(100, 70, 60, 10, 10, 10, 12, 12, 10))},
            {Race.Clown,     new RaceData("Clown",     new Stats(90, 60, 70,  8, 10,  8, 12, 12, 14))},
        };

        public static RaceData Get(Race race) => _raceData[race];
    }
}
