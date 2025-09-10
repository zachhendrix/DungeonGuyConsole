namespace Data.Character
{
    public class Character
    {
        private static readonly Character _character = new Character();
        public static Character character => _character;

        public string Name { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }
        public Equipment Equipment { get; set; }
        public Inventory Inventory { get; set; }
        
        private Character()
        {
            Name = "";
            Job = new Job();
            Race = new Race();
            Stats = new Stats(0,0,0,0,0,0,0,0,0);
            Equipment = new Equipment();
            Inventory = new Inventory();
        }
    }
}