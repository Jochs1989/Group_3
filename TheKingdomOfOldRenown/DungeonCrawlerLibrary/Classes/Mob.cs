using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Mob class to assign information for the Mobs
    public class Mob : LivingCreature 
    {
        private int _id;
        private string _name;
        private string _description;
        private int _attSides;
        private int _attAmount;

        public int ID { get{ return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int AttackDiceSides { get { return _attSides; } set { _attSides = value; } }
        public int AttackDiceAmount { get { return _attAmount; } set { _attAmount = value; } }

        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attSides, int attAmount, string attack, int gold, int xp) : base(hp, ac, attack, gold, xp)
        {
            ID = id;
            Name = name;
            Description = description;
            HP = hp;
            AC = ac;
            AttackDiceSides = attSides;
            AttackDiceAmount = attAmount;
            Attack = attack;
            Gold = gold; //TODO random gold mob holds
            XP = xp;
        }

        // This is how you make a copy of a mob!!!
        public Mob(Mob copy) : base(copy.HP, copy.AC, copy.Attack, copy.Gold, copy.XP)
        {
            ID = copy.ID;
            Name = copy.Name;
            Description = copy.Description;
            HP = copy.HP;
            AC = copy.AC;
            AttackDiceSides = copy.AttackDiceSides;
            AttackDiceAmount = copy.AttackDiceAmount;
            Attack = copy.Attack;
            Gold = copy.Gold;
            XP = copy.XP;
        }
        #endregion
    }
}
