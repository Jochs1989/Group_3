using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Observe
    {
        public static void ObserveArea(Player player,string noun)
        {
            Console.WriteLine($"You see a {player.CurrentRoom.CurrentMob.Name}");

            if (noun == player.CurrentRoom.CurrentMob.Name.ToLower())
            {
                if (player.CurrentRoom.CurrentMob != null)
                {
                    Console.WriteLine($"You see {player.CurrentRoom.CurrentMob.Description}");
                }
                else
                {
                    Console.WriteLine("You don't see anything");
                }
            }
            
        }
    }
}
