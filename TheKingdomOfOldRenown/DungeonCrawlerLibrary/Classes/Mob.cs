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
        private string _attType;
        private int _itemDrop;


        public int ID { get{ return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int AttackDiceSides { get { return _attSides; } set { _attSides = value; } }
        public int AttackDiceAmount { get { return _attAmount; } set { _attAmount = value; } }
        public string AttackType { get { return _attType; } set { _attType = value; } }
        public List<int> ItemDrop { get { return _itemDrop; } set { _itemDrop = value; } }

        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attSides, int attAmount, string attType, int gold, int xp, bool isDead, int itemDrop) : base(hp, ac, gold, xp, isDead)
        {
            ID = id;
            Name = name;
            Description = description;
            HP = hp;
            AC = ac;
            AttackDiceSides = attSides;
            AttackDiceAmount = attAmount;
            AttackType = attType;
            Gold = RandomGold(gold); 
            XP = RandomXP(xp);
            IsDead = isDead;
            ItemDrop = RandomItemsDropped(itemDrop);
        }

        private List<int> RandomItemsDropped(int itemDrop)
        {
            List<int> newItemList;
            switch (itemDrop)
            {
                case 0:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(1, 20)).ID);
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(1, 20)).ID);
                case 1:
                    return newGold = RandomNumGenerator.NumberBetween(20, 30);
                case 2:
                    return newGold = RandomNumGenerator.NumberBetween(30, 50);
                case 3:
                    return newGold = RandomNumGenerator.NumberBetween(50, 75);
                case 4:
                    return newGold = RandomNumGenerator.NumberBetween(100, 150);
                case 5:
                    return newGold = RandomNumGenerator.NumberBetween(750, 750);
                case 6:
                    return newGold = RandomNumGenerator.NumberBetween(1500, 1500);
                default:
                    return 0;
            }
        }

        private int RandomGold(int gold)
        {
            int newGold;
            switch (gold)
            {
                case 0:
                    return newGold = RandomNumGenerator.NumberBetween(10, 20);
                case 1:
                    return newGold = RandomNumGenerator.NumberBetween(20, 30);
                case 2:
                    return newGold = RandomNumGenerator.NumberBetween(30, 50);
                case 3:
                    return newGold = RandomNumGenerator.NumberBetween(50, 75);
                case 4:
                    return newGold = RandomNumGenerator.NumberBetween(100, 150);
                case 5:
                    return newGold = RandomNumGenerator.NumberBetween(750, 750);
                case 6:
                    return newGold = RandomNumGenerator.NumberBetween(1500, 1500);
                default:
                    return 0;
            }
        }

        private int RandomXP(int xp)
        {
            int newXP;
            switch (xp)
            {
                case 0:
                    return newXP = RandomNumGenerator.NumberBetween(1, 10);
                case 1:
                    return newXP = RandomNumGenerator.NumberBetween(5, 15);
                case 2:
                    return newXP = RandomNumGenerator.NumberBetween(15, 25);
                case 3:
                    return newXP = RandomNumGenerator.NumberBetween(25, 35);
                case 4:
                    return newXP = RandomNumGenerator.NumberBetween(35, 50);
                case 5:
                    return newXP = RandomNumGenerator.NumberBetween(100, 100);
                case 6:
                    return newXP = RandomNumGenerator.NumberBetween(200, 200);
                default:
                    return 0;
            }
        }

        // This is how you make a copy of a mob!!!
        public Mob(Mob copy) : base(copy.HP, copy.AC, copy.Gold, copy.XP, copy.IsDead)
        {
            ID = copy.ID;
            Name = copy.Name;
            Description = copy.Description;
            HP = copy.HP;
            AC = copy.AC;
            AttackDiceSides = copy.AttackDiceSides;
            AttackDiceAmount = copy.AttackDiceAmount;
            AttackType = copy.AttackType;
            Gold = copy.Gold;
            XP = copy.XP;
            IsDead = copy.IsDead;
        }
        #endregion
    }
}
