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
        private int _damage;
        private int _diceAmount;
        private int _diceSides;
        private int _cost;

        public int Damage { get { return _damage; } set { _damage = value; } }
        public int DiceAmount { get { return _diceAmount; } set { _diceAmount = value; } }
        public int DiceSides { get { return _diceSides; } set { _diceSides = value; } }
        // Constructor to assign information gathered
        public Weapon(int id, string name, string description, int price, bool canEquipt, int damage, int diceAmount, int diceSides) : base(id, name, description, price, canEquipt)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanEquipt = canEquipt;
            Damage = damage;
            DiceAmount = diceAmount;
            DiceSides = diceSides;
            
        }
    }
}
