using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class RollDice
    {
        public static int PlayerDiceRoll(Player player)
        {
            int sum = 0;
            int diceAmount = player.Equipment.DiceAmount;
            int diceSides = player.Equipment.DiceSides;
            

            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }

        public static int MonsterDiceRoll(Mob monster)
        {

            int sum = 0;
            int diceAmount = monster.AttackDiceAmount;
            int diceSides = monster.AttackDiceSides;


            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }
    }
}
