using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Item class to assign information for the items
    public class Item
    {
        private int _id;
        private string _name;
        private string _description;
        private int _price;
        private bool _canEquipt;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public bool CanEquipt { get { return _canEquipt; } set { _canEquipt = value; } }

        // Constructor to assign information gathered
        public Item(int id, string name, string description, int price, bool canEquipt)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanEquipt = canEquipt;
        }
    }
}
