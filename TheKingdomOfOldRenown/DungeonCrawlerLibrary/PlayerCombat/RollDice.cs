using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class RollDice
    {
        public static int PlayerDiceRoll()
        {
            Player player = LoadPlayerFromFile.LoadPlayer("jeff");
            int sum = 0;
            int diceAmount = player.Equipment.;
            int diceSides = Player._player.Equipment.DiceSides;
            

            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }

        public static int MonsterDiceRoll()
        {

            int sum = 0;
            int diceAmount = Mob._mob.AttackDiceAmount;
            int diceSides = Mob._mob.AttackDiceSides;


            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }
    }
}
