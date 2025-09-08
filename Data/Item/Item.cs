namespace Data.Itemization
{
    public class ItemObject
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? Weight { get; set; }
        public int? BaseValue { get; set; }
        public ItemType Type { get; set; }

        public ItemObject(string name, string description, float? weight, int baseValue, ItemType type)
        {
            Name = name;
            Description = description;
            Weight = weight;
            BaseValue = baseValue;
            Type = type;
        }

        public enum ItemType
        {
            Weapon,
            Armor,
            Ring,
            Potion,
            Treasure,
            Key
        }
    }
}
