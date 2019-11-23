using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Observe
    {
        public static void ObserveArea(string noun)
        {
            Console.WriteLine($"You see a {Player.CurrentRoom.CurrentMob.Name}");

            if (noun == Player.CurrentRoom.CurrentMob.Name.ToLower())
            {
                if (Player.CurrentRoom.CurrentMob != null)
                {
                    Console.WriteLine($"You see {Player.CurrentRoom.CurrentMob.Description}");
                }
                else
                {
                    Console.WriteLine("You don't see anything");
                }
            }
            
        }
    }
}
