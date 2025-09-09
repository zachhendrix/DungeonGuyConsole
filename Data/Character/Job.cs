namespace Data.Character
{
    public enum Job
    {
        Warrior,
        Mage,
        Rogue,
        Knight,
        Paladin,
        Berserker,
        Guardian,
        Monk,
        Ranger,
        Duelist,
        Swashbuckler,
        Gunslinger,
        Warlock,
        Necromancer,
        Battlemage,
        Cleric,
        Druid,
        Bard,
        Beastmaster,
        Summoner,
        Alchemist,
        Artificer,
        Engineer,
        Inquisitor,
        Clown,
        Mime,
        Janitor,
        Influencer,
        Chef,
        Lawyer
    }

    public class JobData
    {
        public string Name;
        public int HealthModifier;
        public int ManaModifier;
        public int StaminaModifier;
        public int StrengthModifier;
        public int DexterityModifier;
        public int ConstitutionModifier;
        public int IntelligenceModifier;
        public int WisdomModifier;
        public int CharismaModifier;

        public JobData(string name, int healthMod, int manaMod, int staminaMod, int strengthMod, int dexterityMod, int constitutionMod, int intelligenceMod, int wisdomMod, int charismaMod)
        {
            Name = name;
            HealthModifier = healthMod;
            ManaModifier = manaMod;
            StaminaModifier = staminaMod;
            StrengthModifier = strengthMod;
            DexterityModifier = dexterityMod;
            ConstitutionModifier = constitutionMod;
            IntelligenceModifier = intelligenceMod;
            WisdomModifier = wisdomMod;
            CharismaModifier = charismaMod;
        }
    }

    public static class JobDatabase
    {
        private static readonly Dictionary<Job, JobData> _jobData = new()
        {
            {Job.Warrior,     new JobData("Warrior",     20,  0, 20, 14,  5, 11,  0,  0,  0)},  // total 40
            {Job.Mage,        new JobData("Mage",         5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Rogue,       new JobData("Rogue",       10,  5, 20,  6, 15,  6,  0,  0,  3)},  // total 35
            {Job.Knight,      new JobData("Knight",      20,  0, 20, 11,  6, 13,  0,  0,  0)},  // total 40
            {Job.Paladin,     new JobData("Paladin",     15,  0, 20, 11,  6, 11,  0,  2,  0)},  // total 35
            {Job.Berserker,   new JobData("Berserker",   20,  0, 20, 13,  4,  7,  0,  0,  6)},  // total 40
            {Job.Guardian,    new JobData("Guardian",    20,  0, 20,  9,  6, 15,  0,  0,  0)},  // total 40
            {Job.Monk,        new JobData("Monk",        10,  5, 20,  8, 10,  8,  0,  4,  0)},  // total 35
            {Job.Ranger,      new JobData("Ranger",      10,  5, 20,  8, 13,  5,  0,  0,  4)},  // total 35
            {Job.Duelist,     new JobData("Duelist",     10,  5, 20, 10, 13,  5,  0,  0,  2)},  // total 35
            {Job.Swashbuckler,new JobData("Swashbuckler",10,  5, 20, 10, 13,  5,  0,  0,  2)},  // total 35
            {Job.Gunslinger,  new JobData("Gunslinger",  10,  5, 20, 10, 13,  5,  0,  0,  2)},  // total 35
            {Job.Warlock,     new JobData("Warlock",      5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Necromancer, new JobData("Necromancer",  5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Battlemage,  new JobData("Battlemage",  10, 15,  5,  6,  4,  6,  8,  4,  2)},  // total 30
            {Job.Cleric,      new JobData("Cleric",      10, 15,  5,  4,  4,  6,  4,  8,  4)},  // total 30
            {Job.Druid,       new JobData("Druid",       10, 15,  5,  4,  4,  6,  8,  8,  0)},  // total 30
            {Job.Bard,        new JobData("Bard",        10, 10, 10,  4,  8,  4,  4,  4,  6)},  // total 30
            {Job.Beastmaster, new JobData("Beastmaster", 10,  5, 20,  6,  8,  6,  4,  4,  2)},  // total 35
            {Job.Summoner,    new JobData("Summoner",     5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Alchemist,   new JobData("Alchemist",    5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Artificer,   new JobData("Artificer",    5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Engineer,    new JobData("Engineer",     5, 20,  5,  0,  4,  4, 12, 10,  0)},  // total 30
            {Job.Inquisitor,  new JobData("Inquisitor",  15,  5, 15, 10,  6, 10,  0,  4,  0)},  // total 35
            {Job.Clown,       new JobData("Clown",       10, 10, 10,  4,  8,  4,  4,  4,  6)},  // total 30
            {Job.Mime,        new JobData("Mime",        10, 10, 10,  4,  8,  4,  4,  4,  6)},  // total 30
            {Job.Janitor,     new JobData("Janitor",     10,  5, 15,  6,  6,  6,  4,  4,  4)},  // total 30
            {Job.Influencer,  new JobData("Influencer",   5, 15, 10,  4,  4,  4,  4,  4, 10)},  // total 30
            {Job.Chef,        new JobData("Chef",        10,  5, 15,  6,  6,  6,  4,  4,  4)},  // total 30
            {Job.Lawyer,      new JobData("Lawyer",       5, 15, 10,  4,  4,  4,  4,  4, 10)},  // total 30
        };

        public static JobData Get(Job job) => _jobData[job];
    }
}
