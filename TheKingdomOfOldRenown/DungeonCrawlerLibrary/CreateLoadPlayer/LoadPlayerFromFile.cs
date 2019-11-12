﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class LoadPlayerFromFile
    {
        // After the user enters their username, the program see's if the file exist. Then if the file is present the program will write all information to player.cs.
        // Also the program sends back the information for use in identifying if the user knows the password.
        public static Player LoadPlayer(string username)
        {
            Player oldplayer = new Player("name", "pw", "class", "race", 1, 0, 0, 0, "attackType", 0, 0);
            if (File.Exists($"{username}.csv"))                                                 // Sees if the file exists
            {
                using (StreamReader fileReader = new StreamReader($"{username}.csv"))           // Opens the file
                {
                    fileReader.ReadLine();

                    while (!fileReader.EndOfStream)
                    {
                        var line = fileReader.ReadLine();
                        var values = line.Split(',');

                        return oldplayer = new Player(values[0], values[1], values[2], values[3], int.Parse(values[4]), int.Parse(values[5]) , int.Parse(values[6]), int.Parse(values[7]), values[8], int.Parse(values[9]), int.Parse(values[10])); // returns file informaiton for password varification.
                    }
                    return oldplayer;
                }
            }
            else
            {
                Console.WriteLine("UserName does not exist!");
                return null;
            }
        }
    }
}
