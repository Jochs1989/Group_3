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
            foreach (Room name in GameAttributes.rooms)
            {
                Console.WriteLine(name.RoomName);
            }
        }
    }
}
