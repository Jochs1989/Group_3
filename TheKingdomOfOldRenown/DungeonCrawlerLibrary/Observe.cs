using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Observe
    {
        public static void ObserveArea()
        {
            if(Player.CurrentRoom.MobRoll != null)
            {
                for (int i = 0; i < Player.CurrentRoom.mobPicked.Count; i++)
                {
                    Console.WriteLine($"You see a {Player.CurrentRoom.mobPicked[i].Name}");
                }
                
            }
            else
            {
                Console.WriteLine("You don't see anything");
            }
        }
    }
}
