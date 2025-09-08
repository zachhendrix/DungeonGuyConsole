using Data.Itemization;

namespace Data.Character
{
    public class Equipment
    {
        public ItemObject? MainHand { get; private set; }
        public ItemObject? OffHand { get; private set; }
        public ItemObject? Head { get; private set; }
        public ItemObject? Body { get; private set; }
        public ItemObject? Legs { get; private set; }
        public ItemObject? Feet { get; private set; }
        public ItemObject? RightRing { get; private set; }
        public ItemObject? LeftRing { get; private set; }

        public enum Slot
        {
            MainHand,
            OffHand,
            Head,
            Body,
            Legs,
            Feet,
            RightRing,
            LeftRing
        }

        public bool Equip(ItemObject item, Slot slot)
        {
            switch (slot)
            {
                case Slot.MainHand:
                    if (item is Weapon)
                    {
                        MainHand = item;
                        return true;
                    }
                    break;

                case Slot.OffHand:
                    if (item is Weapon)
                    {
                        OffHand = item;
                        return true;
                    }
                    break;

                case Slot.Head:
                    if (item is Armor)
                    {
                        Head = item;
                        return true;
                    }
                    break;

                case Slot.Body:
                    if (item is Armor)
                    {
                        Body = item;
                        return true;
                    }
                    break;

                case Slot.Legs:
                    if (item is Armor)
                    {
                        Legs = item;
                        return true;
                    }
                    break;

                case Slot.Feet:
                    if (item is Armor)
                    {
                        Feet = item;
                        return true;
                    }
                    break;
                case Slot.RightRing:
                    if (item is Armor)
                    {
                        RightRing = item;
                        return true;
                    }
                    break;
                case Slot.LeftRing:
                    if (item is Armor)
                    {
                        LeftRing = item;
                        return true;
                    }
                    break;
            }

            return false;
        }

        public bool Unequip(Slot slot)
        {
            switch (slot)
            {
                case Slot.MainHand:
                    MainHand = null;
                    return true;
                case Slot.OffHand:
                    OffHand = null;
                    return true;
                case Slot.Head:
                    Head = null;
                    return true;
                case Slot.Body:
                    Body = null;
                    return true;
                case Slot.Legs:
                    Legs = null;
                    return true;
                case Slot.Feet:
                    Feet = null;
                    return true;
                case Slot.RightRing:
                    Feet = null;
                    return true;
                case Slot.LeftRing:
                    Feet = null;
                    return true;
            }

            return false;
        }

        public ItemObject? GetEquippedItem(Slot slot)
        {
            return slot switch
            {
                Slot.MainHand => MainHand,
                Slot.OffHand => OffHand,
                Slot.Head => Head,
                Slot.Body => Body,
                Slot.Legs => Legs,
                Slot.Feet => Feet,
                Slot.RightRing => RightRing,
                Slot.LeftRing => LeftRing,
                _ => null
            };
        }
    }
}
