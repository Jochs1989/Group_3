using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    
    public class Combat
    {
        public void RunCombat()
        {
            int playerDamage;
            int mobDamage;
            Mob monster;
            int playerAttack = RandomNumGenerator.NumberBetween(1, 20);
            int monsterAttack = RandomNumGenerator.NumberBetween(1, 20);

            do
            {
                Console.WriteLine($"You attack with a {player.Equipment.Name} and roll a {playerAttack}");

                if (playerAttack >= monster.a)
                {
                    playerDamage = RollDice.PlayerDiceRoll(player);

                    Console.WriteLine($"You hit {monster.Name} for {playerDamage}");

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
                    mobDamage = RollDice.MonsterDiceRoll(monster);

                    Console.WriteLine($"The {monster.Name} hits for {mobDamage}");

                    if(player.HP == 0)
                    {
                        // TODO
                    }
                }
                else
                {
                    Console.WriteLine($"The {monster.Name} Missed!");
                }
            }while (monster.HP != 0 && player.HP != 0);

        }
    }
}
