using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class SavePlayer
    {
        public static void Saving(Player player)
        {
            Console.WriteLine("\n.........Saving...........\n");
            // The players information is created using a previous object that stored the user's input for player creation.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}.csv");

                outputFile.WriteLine($"{player.PlayerName.Trim()},{player.Password.Trim()},{player.PlayerClass.Trim()},{player.PlayerRace.Trim()}," +
                    $"{player.PlayerLevel},{player.Equipment.BeginningWeapon},{player.HP},{player.AC},{player.Attack},{player.Gold},{player.XP}");

                outputFile.Close();
            }

            catch
            {
                Console.WriteLine("File Read Error");
            }
        }
    }
}
