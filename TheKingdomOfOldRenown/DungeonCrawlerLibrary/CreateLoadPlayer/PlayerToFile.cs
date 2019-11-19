using System;
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

                outputFile.WriteLine($"{player.PlayerName.Trim()},{player.Password.Trim()},{player.PlayerClass.Trim()},{player.PlayerRace.Trim()}," +
                    $"{player.PlayerLevel},{player.Equipment.ID},{player.HP},{player.AC},{player.Gold},{player.XP},{player.IsDead}");

                outputFile.Close();
            }

            catch
            {
                Console.WriteLine("File Read Error");
            }
        }
    }
}
