namespace Data.Itemization
{
    public class Treasure : ItemObject
    {
        public Treasure(string name, string description, float weight, int baseValue)
            : base(name, description, weight, baseValue, ItemType.Treasure)
        {
        }
    }
}