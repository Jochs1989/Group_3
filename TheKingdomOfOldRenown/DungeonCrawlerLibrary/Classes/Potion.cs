﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Potion class to assign information for the Potions
    public class Potion : InheritItem
    {
        private int _hpRecovery;
        private int _mpRecovery;
        private int _attackUP;
        private int _acUP;

        public int HPRecovery { get { return _hpRecovery; } set { _hpRecovery = value; } }
        public int MPRecovery { get { return _mpRecovery; } set { _mpRecovery = value; } }
        public int AttackUP { get { return _attackUP; } set { _attackUP = value; } }
        public int ACUP { get { return _acUP; } set { _acUP = value; } }

        // Constructor to assign information gathered
        public Potion(int hpRecovery, int mpRecovery, int attackUP, int acUP, int id, string name, string description, int price) : base(id, name, description, price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            HPRecovery = hpRecovery;
            MPRecovery = mpRecovery;
            AttackUP = attackUP;
            ACUP = acUP;
        }
    }
}
