namespace Data.Itemization
{
    public class Potion : ItemObject
    {
        public EffectCategory Effect { get; set; }
        public int Duration { get; set; }

        public Potion(string name, string description, float weight, int baseValue, EffectCategory effect)
            : base(name, description, weight, baseValue, ItemType.Potion)
        {
            Effect = effect;
        }

        public enum EffectCategory
        {
            None,
            Heal,
            Harm,
            Alter
        }

        public static class EffectTypes
        {
            public enum HealEffects
            {
                Health,
                Mana,
                HealthRegen,
                ManaRegen
            }

            public enum HarmEffects
            {
                Harm,
                Poison,
                Paralysis,
                Sleep,
                Fear,
                Charm,
                Rage
            }

            public static class AlterEffects
            {
                public enum Boosts
                {
                    StaminaBoost,
                    SpeedBoost,
                    StrengthBoost,
                    DefenseBoost,
                    LuckBoost,
                }

                public enum Resistances
                {
                    Invisibility,
                    FireResistance,
                    WaterBreathing,
                    PoisonResist,
                    CurePoison,
                    CureDisease,
                    Invulnerability
                }

                public enum Transformations
                {
                    Shrink,
                    Growth,
                    Teleport,
                    AnimalForm,
                    StoneSkin
                }

                public enum Utility
                {
                    Levitation,
                    Clairvoyance,
                    MindControl,
                    NightVision,
                    TimeSlow,
                    TimeSpeed,
                    Reflect,
                    Shield,
                    Blink,
                    Ethereal
                }
            }
        }
    }
}
