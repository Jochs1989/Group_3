using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
   public class LivingCreature
    {
        #region Properties

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int Attack { get; set; }

        #endregion

        // Constructor to assign information gathered
        #region Constructors
        public LivingCreature(int id, string name, string description, int hp, int ac, int attack)
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
