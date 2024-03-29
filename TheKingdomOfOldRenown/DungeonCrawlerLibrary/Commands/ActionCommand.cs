﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class ActionCommand
    {
        // Method that takes the users input and splits it allowing for more precise player control
        public static void PlayerChoice(string input, Player player)
        {
            // Splits the users entry into 2 words, then save the first half to verb second have to noun for use.
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

            // Where the verb dictates the action and the noun gets past to the new class method for precise decisions.
            switch (verb)
            {
                case "move":
                    {
                        PlayerMovement.DisplayMovement(player, noun);
                        break;
                    }
                case "attack":
                    {
                        Combat.RunCombat(player, noun);
                        break;
                    }
                case "look":
                    {
                        Observe.ObserveArea(player, noun);
                        break;
                    }
                case "save":
                    {
                        SavePlayer.Saving(player);
                        break;
                    }
                case "equip":
                    {
                        EquipWeapon.EquipmentChange(player, noun);
                        break;
                    }
                case "use":
                    {
                        EquipWeapon.ItemUse(player, noun);
                        break;
                    }
                case "location":
                    {
                        Console.WriteLine($"You are Currently in {player.CurrentRoom.RoomName}");
                        break;
                    }
                case "quit":
                    {
                        Environment.Exit(1);
                        break;
                    }
                case "menu":
                    {
                        foreach(Menu menuOption in GameAttributes.options)
                        {
                            Console.WriteLine(menuOption.Options);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Type menu to see options");
                        break;
                    }
            }
        }    
    }
}

