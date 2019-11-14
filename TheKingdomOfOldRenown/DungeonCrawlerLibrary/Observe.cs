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
            Console.WriteLine($"You see a {Player.CurrentRoom.mobPicked[0].Name}");

            if (noun == Player.CurrentRoom.mobPicked[0].Name.ToLower())
            {
                if (Player.CurrentRoom.CurrentMob != null)
                {
                    Console.WriteLine($"You see {Player.CurrentRoom.mobPicked[0].Description}");
                }
                else
                {
                    Console.WriteLine("You don't see anything");
                }
            }
            
        }
    }
}
