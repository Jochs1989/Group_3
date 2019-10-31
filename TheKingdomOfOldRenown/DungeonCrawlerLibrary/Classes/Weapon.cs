using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Weapon class to assign information for the Weapons
    public class Weapon : Item
    {
   
        // Constructor to assign information gathered
        public Weapon(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
