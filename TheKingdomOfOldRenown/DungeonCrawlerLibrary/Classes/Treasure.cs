using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Treasure class to assign information for the Treasures
    public class Treasure : Item 
    {
        private bool _questItem;

        public bool QuestItem { get { return _questItem; } set { _questItem = value; } }

        // Constructor to assign information gathered
        public Treasure(int id, string name, string description, int price, bool canEquipt, bool questItem) : base(id, name, description, price, canEquipt)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanEquipt = canEquipt;
            QuestItem = questItem;
        }
    }
}
