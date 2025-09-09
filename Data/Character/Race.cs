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
        public int BaseHealth;
        public int BaseMana;
        public int BaseStamina;
        public int BaseStrength;
        public int BaseDexterity;
        public int BaseConstitution;
        public int BaseIntelligence;
        public int BaseWisdom;
        public int BaseCharisma;

        public RaceData(string name, int health, int mana, int stamina, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            BaseHealth = health;
            BaseMana = mana;
            BaseStamina = stamina;
            BaseStrength = strength;
            BaseDexterity = dexterity;
            BaseConstitution = constitution;
            BaseIntelligence = intelligence;
            BaseWisdom = wisdom;
            BaseCharisma = charisma;
        }
    }

    public static class RaceDatabase
    {
        private static readonly Dictionary<Race, RaceData> _raceData = new()
        {
            {Race.Human,     new RaceData("Human",     100, 50, 70, 12, 12, 10, 10, 10, 10)},
            {Race.Elf,       new RaceData("Elf",        80, 80, 50,  8, 14,  8, 14, 10, 10)},
            {Race.Dwarf,     new RaceData("Dwarf",     130, 30, 80, 12,  8, 12,  8, 12, 12)},
            {Race.Halfling,  new RaceData("Halfling",   60, 40, 110,  6, 16,  8, 10, 12, 12)},
            {Race.Gnome,     new RaceData("Gnome",      70, 70, 70,  8, 10, 10, 12, 12, 12)},
            {Race.HalfElf,   new RaceData("Half-Elf",   90, 60, 70, 10, 10, 10, 10, 12, 12)},
            {Race.HalfOrc,   new RaceData("Half-Orc",  120, 30, 90, 14,  8, 12,  8, 10, 12)},
            {Race.Orc,       new RaceData("Orc",       140, 20, 80, 14,  8, 12,  8, 10, 12)},
            {Race.Goblin,    new RaceData("Goblin",     60, 30, 110,  8, 12,  8, 10, 10, 16)},
            {Race.Troll,     new RaceData("Troll",     150, 20, 70, 16,  6, 14,  6, 10, 12)},
            {Race.Undead,    new RaceData("Undead",    100, 50, 70, 10, 10, 10, 12, 10, 12)},
            {Race.Vampire,   new RaceData("Vampire",    90, 80, 50, 10, 12, 10, 12, 10, 10)},
            {Race.Werewolf,  new RaceData("Werewolf",  130, 30, 80, 14, 10, 12,  8, 10, 10)},
            {Race.Fairy,     new RaceData("Fairy",      70, 80, 60,  6, 16,  6, 16, 10, 10)},
            {Race.Golem,     new RaceData("Golem",     160, 20, 60, 16,  6, 14,  6, 10, 12)},
            {Race.Plantfolk, new RaceData("Plantfolk", 110, 40, 70, 10,  8, 12, 12, 10, 12)},
            {Race.Robot,     new RaceData("Robot",     130, 30, 80, 14,  8, 14, 10,  8, 10)},
            {Race.Alien,     new RaceData("Alien",     100, 70, 60, 10, 10, 10, 12, 12, 10)},
            {Race.Clown,     new RaceData("Clown",      90, 60, 70,  8, 10,  8, 12, 12, 14)},
        };

        public static RaceData Get(Race race) => _raceData[race];
    }
}
