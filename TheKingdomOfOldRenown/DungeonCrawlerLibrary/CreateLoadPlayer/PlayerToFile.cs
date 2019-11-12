﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class PlayerToFile
    {
        public static void SavePlayerData(Player player)
        {
            // The players information is created using a previous object that stored the user's input for player creation.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}.csv");
                outputFile.WriteLine("Character");
                outputFile.WriteLine(player.PlayerName);
                outputFile.WriteLine(player.Password);
                outputFile.WriteLine(player.PlayerClass);
                outputFile.WriteLine(player.PlayerRace);
                outputFile.WriteLine(player.PlayerLevel);
                outputFile.WriteLine(player.Equipment);
                outputFile.WriteLine(player.HP);
                outputFile.WriteLine(player.AC);
                outputFile.WriteLine(player.Attack);
                outputFile.WriteLine(player.Gold);
                outputFile.WriteLine(player.XP);
                outputFile.Close();
            }

            catch
            {
                Console.WriteLine("File Read Error");
            }
        }
    }
}
