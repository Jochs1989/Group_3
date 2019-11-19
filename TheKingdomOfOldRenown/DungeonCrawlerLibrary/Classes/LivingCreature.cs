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
        private int _gold;
        private int _xp;
        private bool _isDead;


        #region Properties

        public int HP { get { return _hp; } set { _hp = value; } }
        public int AC { get { return _ac; } set { _ac = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }

        #endregion

        // Constructor to assign information gathered
        #region Constructors
        public LivingCreature(int hp, int ac, int gold, int xp, bool isDead)
        {
            HP = hp;
            AC = ac;
            Gold = gold;
            XP = xp;
            IsDead = isDead;
        }

        #endregion
    }
}
