using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    
    public class Combat
    {
        public static void RunCombat(Player player)
        {
            bool exit = false;
            int playerDamage;
            int mobDamage;
            List<Mob> mob = Player.CurrentRoom.mobPicked;

            
            // Keeps the do while going as long as the mob/player hasn't died.
            do
            {
                //checks to make sure the mob isn't dead
                if (mob.Any())
                {
                    // rolls the players attack
                    int playerAttack = RandomNumGenerator.NumberBetween(1, 20);
                    Console.WriteLine($"You attack with a {player.Equipment.Name} and roll a {playerAttack}");

                    if (playerAttack >= mob[0].AC)
                    {
                        playerDamage = RollDice.PlayerDiceRoll(player);

                        Console.WriteLine($"You hit {mob[0].Name} for {playerDamage}");
                        mob[0].HP -= playerDamage;
                        Console.WriteLine($"The {mob[0].Name} has {mob[0].HP}!");

                        if (mob[0].HP <= 0)
                        {
                            mob.Remove(mob[0]);
                            exit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You Missed!!!");
                    }
                    // mobs turn to attack if it is still alive, rolls the mobs attacks and continues combat until the player or mob dies
                    if (mob.Any())
                    {
                        int monsterAttack = RandomNumGenerator.NumberBetween(1, 20);
                        
                        if (monsterAttack > player.AC)
                        {
                            mobDamage = RollDice.MonsterDiceRoll(mob[0]);

                            Console.WriteLine($"The {mob[0].Name} attacks and rolls a {monsterAttack}");
                            Console.WriteLine($"The {mob[0].Name} hits for {mobDamage}");
                            player.HP -= mobDamage;
                            Console.WriteLine($"The {player.PlayerName} has {player.HP}!");

                            if (player.HP < 0)
                            {
                                Console.WriteLine("You have died!");
                                exit = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The {mob[0].Name} Missed!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You have won!");
                        exit = true;
                    }
                    Console.WriteLine($"Press enter to continue!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"The monster is dead");
                    exit = true;
                }
                

            } while (exit == false);

        }
    }
}
