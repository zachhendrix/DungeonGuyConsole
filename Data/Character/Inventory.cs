using Data.Itemization;

namespace Data.Character
{
    public class Inventory
    {
        public List<ItemObject>? Items { get; set; }

        public void AddItem(ItemObject item) => Items?.Add(item);
        public void RemoveItem(ItemObject item) => Items?.Remove(item);
        public void RemoveAllItems() => Items?.Clear();

        public float GetInventoryWeight()
        {
            if (Items == null || !Items.Any()) { return 0; }

            return Items.Sum(item => item.Weight ?? 0);
        }
    }
}
