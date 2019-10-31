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
        #region Fields

        #endregion

        #region Properties 

        #endregion
        
        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attack) : base(id, name, description, hp, ac, attack)
        {
            ID = id;
            Name = name;
            HP = hp;
            Description = description;
            AC = ac;
            Attack = attack; 
        }
        #endregion
    }
}
