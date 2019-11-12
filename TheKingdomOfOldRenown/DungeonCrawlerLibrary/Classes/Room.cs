using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Room class to assign information for the Room, the player class access a room list which has information from here.
    public class Room
    {
        private int _id;
        private string _roomName;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private Mob _mobs;

        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return _roomName; } set { _roomName = value; } }
        public int North { get { return _north; } set { _north = value; } }
        public int South { get { return _south; } set { _south = value; } }
        public int East { get { return _east; } set { _east = value; } }
        public int West { get { return _west; } set { _west = value; } }
        public Mob MobRoll { get { return _mobs; } set { _mobs = value; } }
        public List<Mob> mobPicked = new List<Mob>();

        // Constructor to assign incase no information is available
        public Room()
        {
            ID = 0;
            RoomName = null;
            North = 0;
            South = 0;
            East = 0;
            West = 0;
        }
        // Constructor to assign information gathered
        public Room(int id, string roomName, int north, int south, int east, int west, int mobRoll)
        {
            ID = id;
            RoomName = roomName;
            North = north;
            South = south;
            East = east;
            West = west;

            if (mobRoll > -1)
            {
                if (mobRoll < 1)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(0, 9);
                    MobRoll = new Mob(GameAttributes.mobs[rolledMob]);
                    mobPicked.Add(MobRoll);

                }
                else if (mobRoll < 2)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(10, 19);
                    MobRoll = new Mob(GameAttributes.mobs[rolledMob]);
                    mobPicked.Add(MobRoll);
                }
                else if (mobRoll < 3)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(20, 29);
                    MobRoll = new Mob(GameAttributes.mobs[rolledMob]);
                    mobPicked.Add(MobRoll);
                }
                else if (mobRoll < 4)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(30, 39);
                    MobRoll = new Mob(GameAttributes.mobs[rolledMob]);
                    mobPicked.Add(MobRoll);
                }
                else if (mobRoll < 5)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(40, 49);
                    MobRoll = new Mob(GameAttributes.mobs[rolledMob]);
                    mobPicked.Add(MobRoll);
                }
                else
                {
                    mobPicked.Add(GameAttributes.mobs[mobRoll]);
                }
            }
            
        }
    }
}
