using Data.Character;

namespace Data.Itemization
{
    public class Weapon : ItemObject
    {
        public int Damage { get; }
        public float Condition { get; }
        public DamageTypeEnum DamageType { get; }
        public PhysicalDamageType? PhysicalType { get; }
        public MagicalDamageType? MagicalType { get; }
        public Equipment.Slot Slot { get; set; }

        public Weapon(string name, string description, float weight, int baseValue, int damage, float condition, Equipment.Slot slot, DamageTypeEnum damageType, PhysicalDamageType? physicalType = null, MagicalDamageType? magicalType = null)
            : base(name, description, weight, baseValue, ItemType.Weapon)
        {
            Damage = damage;
            Condition = condition;
            DamageType = damageType;
            Slot = slot;
            PhysicalType = damageType == DamageTypeEnum.Physical ? physicalType : null;
            MagicalType = damageType == DamageTypeEnum.Magical ? magicalType : null;
        }

        public enum DamageTypeEnum
        {
            Physical,
            Magical
        }

        public enum PhysicalDamageType
        {
            Bludgeoning,
            Slashing,
            Piercing
        }

        public enum MagicalDamageType
        {
            Fire,
            Ice,
            Lightning
        }
    }
}
