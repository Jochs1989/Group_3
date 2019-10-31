﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Treasure class to assign information for the Treasures
    public class Treasure : Item 
    {
     
        // Constructor to assign information gathered
        public Treasure(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
