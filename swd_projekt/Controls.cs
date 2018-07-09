using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Controls
    {
        public static void gameControls()
        {
           
            Console.WriteLine("Welcome to ---\n-----------some intro.");
            Location currentRoom = Location.MapSetUp();

            string input = "";

            while (input != "q")
            {
                Location.DescribeRoom(currentRoom);
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":
                    case "n":
                         if (currentRoom.north != null)
                        {
                            currentRoom = currentRoom.north;
                            Location.AvatarCurrentLocation(currentRoom);
                            Location.EnemyRandomLocation(currentRoom);
                            
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "east":
                    case "e":
                        if (currentRoom.east != null)
                        {
                            currentRoom = currentRoom.east;
                            Location.AvatarCurrentLocation(currentRoom);
                            Location.EnemyRandomLocation(currentRoom);
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "south":
                    case "s":
                         if (currentRoom.south != null)
                        {
                            currentRoom = currentRoom.south;
                            Location.AvatarCurrentLocation(currentRoom);
                            Location.EnemyRandomLocation(currentRoom);
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "west":
                    case "w":
                         if (currentRoom.west != null)
                        {
                            currentRoom = currentRoom.west;
                            Location.AvatarCurrentLocation(currentRoom);
                            Location.EnemyRandomLocation(currentRoom);
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "take":
                    case "t":
                        takeItem(currentRoom);
                        break;
                    case "drop":
                    case "d":
                        dropItem(currentRoom);
                        break;
                    case "inventory":
                    case "i":
                        myInventory();
                        break;
                    case "look":
                    case "l":
                        // Location.DescribeRoom(currentRoom);
                        break;
                        case "attack":
                    case "a":
                        break;
                    case "commands":
                    case "c":
                        Console.WriteLine("commands(c), look(l), inventory(i), take(t) item, drop(d) item, quit(q)");
                        break;
                    case "quit":
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cant use this button. Use another one. If you don't know the Controls press c!");
                        Console.ResetColor();
                        break;
                }   
            }
        }
        public static void takeItem(Location location)
        {
            Console.WriteLine("Which Item do you want to take with you?:");
            string item = Console.ReadLine();
            if (location.items.Count > 0)
            {

                if (location.items.Contains(item))
                {
                    Avatar.inventory.Add(item);
                    location.items.Remove(item);
                }
                else
                {
                    Console.WriteLine("This item does not exist!");
                }
            }
            else
            {
                Console.WriteLine("There are no items in this room!");
            }
            // Console.WriteLine(location.items);
        }

        public static void myInventory()
        {
            if (Avatar.inventory.Count > 0)
            {
                foreach (var i in Avatar.inventory)
                {
                    Console.WriteLine("Inventar: " + i);
                }
            }
            else
            {
                Console.WriteLine("Your bag is empty!");
            }
        }

        public static void dropItem(Location location)
        {
            if (Avatar.inventory.Count > 0)
            {
                myInventory();
                Console.WriteLine("Which item do you want to drop?: ");
                string drop = Console.ReadLine();
                if (Avatar.inventory.Contains(drop))
                {
                    location.items.Add(drop);
                    Avatar.inventory.Remove(drop);
                }
            }
            else
            {
                Console.WriteLine("There is nothing in your bag.");
            }

        }

    }
}