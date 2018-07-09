using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Location
    {
        public string title;
        public string description;
        public int roomNumber;
        public bool enemyLocation;
        public List<string> items = new List<string>();
        public Location north;
        public Location east;
        public Location south;
        public Location west;

        public Location(int _roomNumber, bool _enemyLocation, string _title, string _description)
        {
            roomNumber = _roomNumber;
            enemyLocation = _enemyLocation;
            title = _title;
            description = _description;

        }

        public static Location MapSetUp()
        {
            Location parkingSpot = new Location(
                0,
                false,
               "The parking spot",
               "You're at the Parking slot. It's cold outside and it snows. You're hungry andthere is a supermarket in front of you.");

            Location supermarket = new Location(
                1,
                false,
                "The supermarket",
                "You're in the supermarket. You can see some food and something to eat. In the moment you can't see anybody");
            Items chocolate = new Items("chocolate bar", "It seems to be soo delicious:(");
            Items water = new Items("water bottles", "I'm not so thirsty now, but maybe for later");
            Items bread = new Items("bread", "It looks delicios. I have'nt have eaten something for a long time...");
            supermarket.items.Add("chocolate");
            supermarket.items.Add("water");
            supermarket.items.Add("bread");

            Location office = new Location(
                2,
                true,
                "The office",
                "You're in the office. There is nothing.");

            Location coolingRoom = new Location(
                3,
                false,
                "The cooling room",
                "You're in the cooling room. It's very cold. You can see something to eat and drink. Furthermore you're noticing a flare");
            Items meat = new Items("frozen meat", "Oh, is looks so good. I don't know when I had the last time meat to eat.");
            Items milk = new Items("milk", "It looks old");
            Items plier = new Items("plier", "Hmm..I could need it..");
            Items screwdriver = new Items("rusty screwdriver", "It looks old. I don't know if its useable.");
            coolingRoom.items.Add("meat");
            coolingRoom.items.Add("milk");
            coolingRoom.items.Add("plier");
            coolingRoom.items.Add("screwdriver");

            Location backyard = new Location(
                4,
                false,
                "The backyard",
                "You're at backyard. It's cold outside and it snows. there are fences around you.");

            parkingSpot.south = supermarket;

            supermarket.north = parkingSpot;
            supermarket.east = office;
            supermarket.south = coolingRoom;

            office.west = supermarket;

            coolingRoom.north = supermarket;
            coolingRoom.east = backyard;

            backyard.west = coolingRoom;

            return parkingSpot;
        }

        public static void AvatarCurrentLocation(Location location)
        {
            Avatar.playerLocation = location.roomNumber;
            // RoomCheck();
        }
        public static void EnemyRandomLocation(Location location)
        {
            if (Enemy.dead == false)
            {
                Random rnd = new Random();
                double randomRoomNumber = rnd.NextDouble();
                randomRoomNumber = ((randomRoomNumber * (3.0 - 2.0)) + 2.0);
                if (randomRoomNumber > 1.49)
                {
                    Math.Ceiling(randomRoomNumber);
                }
                else
                {
                    Math.Floor(randomRoomNumber);
                }
                int NewrandomRoomNumber = Convert.ToInt32(randomRoomNumber);
                Enemy.randomLocation = NewrandomRoomNumber;
            }
            else
            {
                Enemy.randomLocation = -1;
            }


        }
        public static void RoomCheck()
        {
            if (Avatar.playerLocation == Enemy.randomLocation)
            {
                Attack.Fight();
            }
        }
        public static void DescribeRoom(Location location)
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(location.title);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine(location.description);
            Console.ResetColor();
            if (location.items.Count > 0)
            {
                Console.WriteLine("In the room you can see these items: ");
                foreach (var item in location.items)
                {
                    Console.WriteLine(item + " - ");
                }
            }
            //win
            if (location.title == "The backyard")
            {
                if (Avatar.inventory.Contains("plier"))
                {
                    Console.WriteLine("You have won!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You can't get over the fences. Search for an Item that could help you!");
                }
            }

            Console.WriteLine(Avatar.playerLocation);
            Console.WriteLine("test random " + Enemy.randomLocation);
            RoomCheck();
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________");
        }
    }
}



