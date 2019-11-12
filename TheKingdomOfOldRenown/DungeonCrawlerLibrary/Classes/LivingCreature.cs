using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
   public class LivingCreature
    {
        private int _hp;
        private int _ac;
        private string _attack;
        private int _gold;
        private int _xp;


        #region Properties

        public int HP { get { return _hp; } set { _hp = value; } }
        public int AC { get { return _ac; } set { _ac = value; } }
        public string Attack { get { return _attack; } set { _attack = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }

        #endregion

        // Constructor to assign information gathered
        #region Constructors
        public LivingCreature(int hp, int ac, string attack, int gold, int xp)
        {
            HP = hp;
            AC = ac;
            Attack = attack;
            Gold = gold;
            XP = xp;
        }

        #endregion
    }
}
