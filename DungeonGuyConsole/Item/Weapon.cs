using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGuyConsole.Item
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public string DamageType { get; set; } // e.g., "Slashing", "Piercing", etc.

        public Weapon()
        {
            Type = "Weapon"; // Set the Type property to "Weapon"
        }
    }
}
