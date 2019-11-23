using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class PlayerInventory : IPotion, ITreasure, IWeapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool QuestItem { get; set; }
        public bool CanUse { get; set; }
        public int HPRecovery { get; set; }
        public int AttackUP { get; set; }
        public int ACUP { get; set; }
        public string Damage { get; set; }
        public int DiceAmount { get; set; }
        public int DiceSides { get; set; }
        public bool CanEquip { get; set; }
        public int Upgrades { get; set; }
    }
}
