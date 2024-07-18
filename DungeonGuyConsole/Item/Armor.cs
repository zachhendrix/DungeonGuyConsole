using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGuyConsole.Item
{
    public class Armor : Item
    {
        public int Defense { get; set; }
        public string Material { get; set; } // e.g., "Leather", "Steel", etc.

        public Armor()
        {
            Type = "Armor"; // Set the Type property to "Armor"
        }
    }
}
