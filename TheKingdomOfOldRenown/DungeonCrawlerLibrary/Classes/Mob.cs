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
      
        
        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attack, int gold) : base(id, name, description, hp, ac, attack, gold)
        {
            ID = id;
            Name = name;
            HP = hp;
            Description = description;
            AC = ac;
            Attack = attack;
            Gold = gold; //TODO random gold mob holds
        }
        #endregion
    }
}
