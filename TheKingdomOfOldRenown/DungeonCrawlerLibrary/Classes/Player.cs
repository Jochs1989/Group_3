using System;
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

        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string PlayerClass { get { return _playerClass; } set { _playerClass = value; } }
        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int PlayerLevel { get { return _playerLevel; } set { _playerLevel = value; } }
        public static Room CurrentRoom { get { return _currentroom; } set { _currentroom = value; } }
        public Weapon Equipment { get { return _equipment; } set { _equipment = value; } }

        // Constructor to assign information gathered
        public Player(string playerName, string password, string playerClass, string race, int playerLevel, Weapon equipment, int hp, int ac, string attack, int gold, int xp)
            : base(hp, ac, attack, gold, xp)
        {
            PlayerName = playerName;
            Password = password;
            PlayerClass = playerClass;
            PlayerRace = race;
            PlayerLevel = playerLevel;
            CurrentRoom = GameAttributes.rooms[0];
            Equipment = equipment;
            HP = hp;
            AC = ac;
            Attack = attack;
            Gold = gold;
            XP = xp;

        }
    }
}
