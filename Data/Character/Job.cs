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
        public Stats Stats;

        public JobData(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }
    }

    public static class JobDatabase
    {
        private static readonly Dictionary<Job, JobData> _jobData = new()
        {
            {Job.Warrior,     new JobData("Warrior",     new Stats(20,  0, 20, 14,  5, 11,  0,  0,  0))}, 
            {Job.Mage,        new JobData("Mage",        new Stats(5, 20,  5,  0,  4,  4, 12, 10,  0))}, 
            {Job.Rogue,       new JobData("Rogue",       new Stats(10,  5, 20,  6, 15,  6,  0,  0,  3))}, 
            {Job.Knight,      new JobData("Knight",      new Stats(20,  0, 20, 11,  6, 13,  0,  0,  0))}, 
            {Job.Paladin,     new JobData("Paladin",     new Stats(15,  0, 20, 11,  6, 11,  0,  2,  0))}, 
            {Job.Berserker,   new JobData("Berserker",   new Stats(20,  0, 20, 13,  4,  7,  0,  0,  6))}, 
            {Job.Guardian,    new JobData("Guardian",    new Stats(20,  0, 20,  9,  6, 15,  0,  0,  0))}, 
            {Job.Monk,        new JobData("Monk",        new Stats(10,  5, 20,  8, 10,  8,  0,  4,  0))}, 
            {Job.Ranger,      new JobData("Ranger",      new Stats(10,  5, 20,  8, 13,  5,  0,  0,  4))}, 
            {Job.Duelist,     new JobData("Duelist",     new Stats(10,  5, 20, 10, 13,  5,  0,  0,  2))},  
            {Job.Swashbuckler,new JobData("Swashbuckler",new Stats(10,  5, 20, 10, 13,  5,  0,  0,  2))}, 
            {Job.Gunslinger,  new JobData("Gunslinger",  new Stats(10,  5, 20, 10, 13,  5,  0,  0,  2))}, 
            {Job.Warlock,     new JobData("Warlock",     new Stats(5, 20,  5,  0,  4,  4, 12, 10,  0))}, 
            {Job.Necromancer, new JobData("Necromancer", new Stats(5, 20,  5,  0,  4,  4, 12, 10,  0))},
            {Job.Battlemage,  new JobData("Battlemage",  new Stats(10, 15,  5,  6,  4,  6,  8,  4,  2))},  
            {Job.Cleric,      new JobData("Cleric",      new Stats(10, 15,  5,  4,  4,  6,  4,  8,  4))}, 
            {Job.Druid,       new JobData("Druid",       new Stats(10, 15,  5,  4,  4,  6,  8,  8,  0))},
            {Job.Bard,        new JobData("Bard",        new Stats(10, 10, 10,  4,  8,  4,  4,  4,  6))},
            {Job.Beastmaster, new JobData("Beastmaster", new Stats(10,  5, 20,  6,  8,  6,  4,  4,  2))}, 
            {Job.Summoner,    new JobData("Summoner",    new Stats( 5, 20,  5,  0,  4,  4, 12, 10,  0))},
            {Job.Alchemist,   new JobData("Alchemist",   new Stats(5, 20,  5,  0,  4,  4, 12, 10,  0))},
            {Job.Artificer,   new JobData("Artificer",   new Stats( 5, 20,  5,  0,  4,  4, 12, 10,  0))},
            {Job.Engineer,    new JobData("Engineer",    new Stats( 5, 20,  5,  0,  4,  4, 12, 10,  0))},
            {Job.Inquisitor,  new JobData("Inquisitor",  new Stats(15,  5, 15, 10,  6, 10,  0,  4,  0))},
            {Job.Clown,       new JobData("Clown",       new Stats(10, 10, 10,  4,  8,  4,  4,  4,  6))},
            {Job.Mime,        new JobData("Mime",        new Stats(10, 10, 10,  4,  8,  4,  4,  4,  6))},
            {Job.Janitor,     new JobData("Janitor",     new Stats(10,  5, 15,  6,  6,  6,  4,  4,  4))},
            {Job.Influencer,  new JobData("Influencer",  new Stats( 5, 15, 10,  4,  4,  4,  4,  4, 10))}, 
            {Job.Chef,        new JobData("Chef",        new Stats(10,  5, 15,  6,  6,  6,  4,  4,  4))},
            {Job.Lawyer,      new JobData("Lawyer",      new Stats(5, 15, 10,  4,  4,  4,  4,  4, 10))},  
        };

        public static JobData Get(Job job) => _jobData[job];
    }
}
