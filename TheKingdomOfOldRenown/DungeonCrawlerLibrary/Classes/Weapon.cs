using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Weapon class to assign information for the Weapons
    public class Weapon : InheritItem
    {
        private string _damage;
        private int _diceAmount;
        private int _diceSides;
        private bool _canEquipt;

        public string Damage { get { return _damage; } set { _damage = value; } }
        public int DiceAmount { get { return _diceAmount; } set { _diceAmount = value; } }
        public int DiceSides { get { return _diceSides; } set { _diceSides = value; } }
        public bool CanEquip { get { return _canEquipt; } set { _canEquipt = value; } }

        // Constructor to assign information gathered
        public Weapon(int id, string name, string description, int price, bool canEquip, string damage, int diceAmount, int diceSides) : base (id, name, description, price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanEquip = canEquip;
            Damage = damage;
            DiceAmount = diceAmount;
            DiceSides = diceSides;
        }
    }
}
