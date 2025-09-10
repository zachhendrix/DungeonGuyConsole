namespace Data.Character
{
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


        public Stats(int health, int mana, int stamina, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Health = health;
            Mana = mana;
            Stamina = stamina;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }
    }
}
