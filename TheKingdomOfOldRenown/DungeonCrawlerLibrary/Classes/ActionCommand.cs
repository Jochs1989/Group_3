using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class ActionCommand
    {
        public static void PlayerChoice(string input, Player player)
        {
            string[] arrayInput = input.Trim().Split(null);

            string verb = arrayInput[0].ToLower() ;
            string noun;
            if (arrayInput.Length == 2)
            {
                 noun = arrayInput[1].ToLower();
            }
            else
            {
                noun = "";
            }


            switch (verb)
            {
                case "move":
                    {
                        PlayerMovement.DisplayMovement(noun);
                        break;
                    }
                case "attack":
                    {
                        Combat.RunCombat(player);
                        break;
                    }
                case "look":
                    {
                        Observe.ObserveArea();
                        break;
                    }
            }
        }    
    }
}

