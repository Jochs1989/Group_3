using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Observe
    {
        // Method that takes in the players information for determining what exist in the players data. Then takes the noun that was passed and finds specially what the user is looking at.
        public static void ObserveArea(Player player,string noun)
        {
            if (player.CurrentRoom.CurrentMob != null && noun == null)
            {
                if (noun == player.CurrentRoom.CurrentMob.Name.ToLower())
                {
                    Console.WriteLine($"You see {player.CurrentRoom.CurrentMob.Description}");
                }
                else
                {
                    Console.WriteLine("You don't see anything");
                }
            }
            if (noun == "inventory")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (InheritItem item in player.Inventory)
                {
                    Console.WriteLine("\nNAME\t\t\t\t\tPrice");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"{item.Name}{item.Price.ToString().PadLeft(25)}");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (noun == "weapon")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n(NAME), (DESCIPTION), (Price)");
                Console.WriteLine($"{player.Equipment.Name} | {player.Equipment.Description} | {player.Equipment.Price}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (noun == "player")
            {
                int xp;
                Console.WriteLine($"\nYou are a {player.PlayerClass}");
                Console.WriteLine($"You have {player.XP%100} XP out of 100");
                Console.WriteLine($"You are level {player.PlayerLevel}");
                Console.WriteLine($"You have {player.HP}");
                Console.WriteLine($"You have {player.PlayerMaxHP} max hp\n");
            }
            if (noun == "")
            {
                Console.WriteLine($"{player.CurrentRoom.Description}");

                if (player.CurrentRoom.CurrentMob != null)
                {
                    Console.WriteLine($"You see a {player.CurrentRoom.CurrentMob.Name}");
                }
                else
                {
                    Console.WriteLine($"You don't see anything of importance.");
                }
            }
            
        }
    }
}
