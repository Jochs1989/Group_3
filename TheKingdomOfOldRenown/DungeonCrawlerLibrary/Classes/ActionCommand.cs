using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class ActionCommand
    {
        public static void PlayerChoice(string input)
        {
            string[] arrayInput = input.Trim().Split(null);

            string verb = arrayInput[0];
            string noun;
            if (arrayInput.Length == 2)
            {
                 noun = arrayInput[1];
            }
            else
            {
                noun = "";
            }


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

