﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawlerLibrary;



namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            bool adminExit = false;
            // Here we call our list creation to create all our list from files we have saved in our bin
            // Then we show the user a welcome screen
            // Finally the program goes to player creation and asks the user if they want to create or load a player.
            
            #region Startup
            ListCreation.FromReader();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to The Kingdom Of Old Renown!"); //ToDo better welcome screeen!
            Console.ForegroundColor = ConsoleColor.White;
            while (adminExit == false)
            {
                Console.WriteLine("Are you a Player or Admin (type 'Quit' to quit program)");
                Console.Write("> ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "admin")
                {
                    DungeonCrawlerForms.Program.Main();
                }
                else if (choice == "player")
                {
                    adminExit = true;
                }
                else if (choice == "quit")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Not an Option!");
                }
            }
            Player player = NewOrOldPlayer.PlayerCreateOrLoad(); //Todo Delete old player profiles
            #endregion Startup

            // Here the game gives the user starting options along with where they are located and what direction they would want to move.
            #region Game Starts
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type 'Menu' to see the Menu\n");

            Console.WriteLine("Type 'Quit' to quit the game\n");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion Game Starts

            //The player is displayed exits points. They have access to either quit, go to the menu, or make a decision.
            #region Player Decision
            do
            {
                ShowExitLocations.DisplayExits(player);                                           // Displays exits for user
                Console.Write("\nPlease enter what you would like to do: > ");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine("");
                if (input == "quit")
                {
                    exit = true;
                }
                else
                {
                    ActionCommand.PlayerChoice(input, player);                              // Moves players location
                }

            } while (exit == false);
            #endregion Player Decision

        }
    }
}
