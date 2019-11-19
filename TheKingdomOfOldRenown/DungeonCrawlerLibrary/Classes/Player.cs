﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Player class to assign information for the player, also tracks the users movement between rooms and allows for player creation.
    public class Player : LivingCreature
    {
        private string _playerName;
        private string _password;
        private string _playerClass;
        private string _playerRace;
        private int _playerLevel;
        private static Room _currentroom;
        private Weapon _equipment;
        public static Player player;


        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string PlayerClass { get { return _playerClass; } set { _playerClass = value; } }
        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int PlayerLevel { get { return _playerLevel; } set { _playerLevel = value; } }
        public Weapon Equipment { get { return _equipment; } set { _equipment = value; } }
        public static Room CurrentRoom { get { return _currentroom; } set { _currentroom = value; } }

        // Constructor to assign information gathered
        public Player(string playerName, string password, string playerClass, string race, int playerLevel, Weapon equipment, int hp, int ac, int gold, int xp, bool isDead)
            : base(hp, ac, gold, xp, isDead)
        {
            PlayerName = playerName;
            Password = password;
            PlayerClass = playerClass;
            PlayerRace = race;
            PlayerLevel = playerLevel;
            Equipment = equipment;
            CurrentRoom = GameAttributes.rooms[0];
            HP = hp;
            AC = ac;
            Gold = gold;
            XP = xp;
            IsDead = isDead;
        }

        public static void AddPlayerXP(Player player, Mob mob)
        {
            player.XP += mob.XP;
        }
    }
}
