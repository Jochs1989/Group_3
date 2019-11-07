using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    
    public class Combat
    {
        public void RunCombat(Mob monster, Player player)
        {
            int playerAttack = RandomNumGenerator.NumberBetween(1, 20);
            int monsterAttack = RandomNumGenerator.NumberBetween(1, 20);

            if(monster.HP != 0 && player.HP != 0)
            {
                Console.WriteLine($"You attack with a {player.Equipment.Name} and roll a {playerAttack}");

                if (playerAttack >= monster.AC)
                {
                    Console.WriteLine($"You hit {monster.Name} for {RollDice.PlayerDiceRoll(player)}");

                    if(monster.HP == 0)
                    {
                        GameAttributes.mobs.Remove(monster);
                    }
                }
                else
                {
                    Console.WriteLine("You Missed!!!");
                }

                Console.WriteLine($"The {monster.Name} attacks and rolls a {monsterAttack}");

                if(monsterAttack > player.AC)
                {
                    Console.WriteLine($"The {monster.Name} hits for {RollDice.MonsterDiceRoll(monster)}");
                }
                else
                {
                    Console.WriteLine($"The {monster.Name} Missed!");
                }
            }

        }
    }
}
