
namespace Data.Itemization
{
    public class Key : ItemObject
    {
        public KeyGrade Grade { get; set; }

        public Key(string name, string description, float weight, int baseValue, KeyGrade keyGrade ) 
            : base(name, description, weight, baseValue, ItemType.Key)
        {
            Grade = keyGrade;
        }

        public enum KeyGrade
        {
            Bronze,
            Silver,
            Gold
        }
    }
}
