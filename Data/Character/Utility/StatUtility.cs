using static Data.Character.Character;

namespace Data.Character.Utility
{
    public static class StatUtility
    {
        public static void InitializeStats()
        {
            RaceData raceData = RaceDatabase.Get(character.Race);
            JobData jobData = JobDatabase.Get(character.Job);
            SetStats(character.Stats, raceData.Stats);
            ModStats(character.Stats, jobData.Stats);
        }

        public static void SetStats(Stats baseStats, Stats modStats)
        {
            baseStats = modStats;
        }

        public static void ModStats(Stats baseStats, Stats modStats)
        {
            baseStats.Health += modStats.Health;
            baseStats.Mana += modStats.Mana;
            baseStats.Stamina += modStats.Stamina;
            baseStats.Strength += modStats.Strength;
            baseStats.Dexterity += modStats.Dexterity;
            baseStats.Constitution += modStats.Constitution;
            baseStats.Intelligence += modStats.Intelligence;
            baseStats.Wisdom += modStats.Wisdom;
            baseStats.Charisma += modStats.Charisma;
        }
    }
}
