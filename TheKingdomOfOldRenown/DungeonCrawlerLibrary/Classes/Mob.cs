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
        private int _gold;
        private int _xp;


        public int ID { get{ return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int AttackDiceSides { get { return _attSides; } set { _attSides = value; } }
        public int AttackDiceAmount { get { return _attAmount; } set { _attAmount = value; } }
        public string AttackType { get { return _attType; } set { _attType = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }
        public int MobRating { get; set; }

        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attSides, int attAmount, string attType, int mobRating,  bool isDead) : base(hp, ac, isDead)
        {
            ID = id;
            Name = name;
            Description = description;
            HP = hp;
            AC = ac;
            AttackDiceSides = attSides;
            AttackDiceAmount = attAmount;
            AttackType = attType;
            Gold = RandomGold(mobRating); 
            XP = RandomXP(mobRating);
            MobRating = mobRating;
            IsDead = isDead;
        }

        // This is how you make a copy of a mob!!!
        public Mob(Mob copy) : base(copy.HP, copy.AC, copy.IsDead)
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
            MobRating = copy.MobRating;
            IsDead = copy.IsDead;
        }
        #endregion

        public static List<InheritItem> RandomItemsDropped(int itemDrop) 
        {
            List<InheritItem> newItemList = new List<InheritItem>();
            switch (itemDrop)
            {
                case 0:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 413)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(301, 305)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(201, 220)));
                    return newItemList;
                    
                case 1:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 415)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(301, 310)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(212, 236)));
                    return newItemList;
                case 2:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 416)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(305, 310)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(212, 252)));
                    return newItemList;
                case 3:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 419)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(305, 314)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(231, 252)));
                    return newItemList;
                case 4:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(415, 419)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(310, 314)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 267)));
                    return newItemList;
                case 5:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(415, 419)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(315, 319)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 267)));
                    return newItemList;
                default:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(415, 419)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(320, 325)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 268)));
                    return newItemList;
            }
        }

        private int RandomGold(int gold)
        {
            switch (gold)
            {
                case 0:
                    return RandomNumGenerator.NumberBetween(10, 20);
                case 1:
                    return RandomNumGenerator.NumberBetween(20, 30);
                case 2:
                    return RandomNumGenerator.NumberBetween(30, 50);
                case 3:
                    return RandomNumGenerator.NumberBetween(50, 75);
                case 4:
                    return RandomNumGenerator.NumberBetween(100, 150);
                case 5:
                    return RandomNumGenerator.NumberBetween(500, 600);
                case 6:
                    return RandomNumGenerator.NumberBetween(600, 700);
                case 7:
                    return RandomNumGenerator.NumberBetween(700, 800);
                case 8:
                    return RandomNumGenerator.NumberBetween(800, 900);
                case 9:
                    return RandomNumGenerator.NumberBetween(900, 1000);
                case 10:
                    return RandomNumGenerator.NumberBetween(1500, 1500);
                default:
                    return 0;
            }
        }

        private int RandomXP(int xp)
        {
            switch (xp)
            {
                case 0:
                    return RandomNumGenerator.NumberBetween(1, 10);
                case 1:
                    return RandomNumGenerator.NumberBetween(5, 15);
                case 2:
                    return RandomNumGenerator.NumberBetween(15, 25);
                case 3:
                    return RandomNumGenerator.NumberBetween(25, 35);
                case 4:
                    return RandomNumGenerator.NumberBetween(35, 50);
                case 5:
                    return RandomNumGenerator.NumberBetween(100, 100);
                case 6:
                    return RandomNumGenerator.NumberBetween(150, 200);
                case 7:
                    return RandomNumGenerator.NumberBetween(225, 250);
                case 8:
                    return RandomNumGenerator.NumberBetween(250, 275);
                case 9:
                    return RandomNumGenerator.NumberBetween(275, 300);
                case 10:
                    return RandomNumGenerator.NumberBetween(400, 400);
                default:
                    return 0;
            }
        }
    }
}
