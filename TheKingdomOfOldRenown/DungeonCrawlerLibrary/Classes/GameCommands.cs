using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class GameCommands
    {
        public static void PlayerChoice(string input)
        {
            string[] arrayInput = input.Split(' ');

            string verb = arrayInput[0];
            string noun = arrayInput[1];

            switch (verb.ToLower())
            {
                case "move":
                    {
                        PlayerMovement.DisplayMovement(noun);
                        break;
                    }
                case "attack":
                    {
                        Combat.RunCombat();
                    }
            }
        }    
    }
}

