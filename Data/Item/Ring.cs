using Data.Character;

namespace Data.Itemization
{
    public class Ring(string name, string description, float weight, int baseValue, Equipment.Slot slot)
               : ItemObject(name, description, weight, baseValue, ItemType.Ring)
    {
        public required string Effect { get; set; }
        public int Duration { get; set; }
        public Equipment.Slot Slot { get; set; } = slot;
    }
}
