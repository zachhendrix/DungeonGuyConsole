namespace Data.Character
{
    public class Character
    {
        public string Name { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }
        public Equipment Equipment { get; set; }
        public Inventory Inventory { get; set; }

        public Character() { }
        
        public Character(string name, Job job, Race race)
        {
            Name = name;
            Job = job;
            Race = race;
            Stats = new Stats();
            Equipment = new Equipment();
            Inventory = new Inventory();
        }
    }
}