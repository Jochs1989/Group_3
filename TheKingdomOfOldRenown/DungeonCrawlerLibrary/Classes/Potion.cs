using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Potion class to assign information for the Potions
    public class Potion : Item 
    {

        // Constructor to assign information gathered
        public Potion(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
