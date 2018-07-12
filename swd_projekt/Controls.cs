using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Controls
    {
        public static string[] words;

        public static Location currentRoom = Location.MapSetUp();

        public static Array splitInput()
        {
            string _input = Console.ReadLine();
            words = _input.Split(' ');
            return words;
        }
        public static void gameControls()
        {
            Enemy enemyInfos = Enemy.EnemySetUp();
            Avatar avatarInfos = Avatar.AvatarSetUp();
            Console.WriteLine("Welcome to ---\n-----------some intro.");

            for (; ; )
            {
                Location.DescribeRoom(currentRoom, avatarInfos, enemyInfos);
                splitInput();

                switch (words[0])
                {
                    case "north":
                    case "n":
                        roomDirection(currentRoom, words[0], avatarInfos, enemyInfos);
                        break;
                    case "east":
                    case "e":
                        roomDirection(currentRoom, words[0], avatarInfos, enemyInfos);
                        break;
                    case "south":
                    case "s":
                        roomDirection(currentRoom, words[0], avatarInfos, enemyInfos);
                        break;
                    case "west":
                    case "w":
                        roomDirection(currentRoom, words[0], avatarInfos, enemyInfos);
                        break;
                    case "take":
                    case "t":
                        try
                        {
                            if (words[1] == "")
                            {
                                Console.WriteLine("You have to choose an item!");
                            }
                            else
                            {
                                takeItem(words[1], currentRoom, avatarInfos);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("I don't understand this input :/ Please write it like this: t/take + itemname.");
                        }
                        break;
                    case "drop":
                    case "d":
                        try
                        {
                            if (words[1] == "")
                            {
                                Console.WriteLine("You have to choose an item!");
                            }
                            else
                            {
                                dropItem(words[1], currentRoom, avatarInfos);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("I don't understand this input :/ Please write it like this: t/take + itemname.");
                        }
                        break;
                    case "inventory":
                    case "i":
                        myInventory(avatarInfos);
                        break;
                    case "look":
                    case "l":
                        Location.LookThroughRoom(currentRoom);
                        break;
                    case "attack":
                    case "a":
                        if (avatarInfos.playerLocation == Enemy.randomLocation)
                        {
                            Attack.Fight(currentRoom, avatarInfos, enemyInfos);
                        }
                        else
                            Console.WriteLine("There's no one to attack!");
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
        public static Location roomDirection(Location location, string words, Avatar avatarInfos, Enemy enemyInfos)
        {
            Location direction = null;
            if (words == "n" || words == "north")
            {
                direction = currentRoom.north;
            }
            else if (words == "e" || words == "east")
            {
                direction = currentRoom.east;
            }
            else if (words == "s" || words == "south")
            {
                direction = currentRoom.south;
            }
            else if (words == "w" || words == "west")
            {
                direction = currentRoom.west;
            }
            if (direction != null)
            {
                currentRoom = direction;
                avatarInfos.AvatarCurrentLocation(currentRoom, avatarInfos, enemyInfos);
            }
            else
            {
                Console.WriteLine("There is no way! Choose another one!");
            }

            return currentRoom;
        }
        public static void takeItem(string words, Location location, Avatar avatarInfos)
        {
            Items foundItem = location.items.Find(x => x.title.Contains(words));
            if (foundItem != null)
            {
                Console.WriteLine("Found: " + foundItem.title);
            }
            else
            {
                Console.WriteLine("This item does not exist!");
            }
            if (location.items.Count > 0)
            {
                location.items.Remove(foundItem);
                avatarInfos.inventory.Add(foundItem);
            }
            else
            {
                Console.WriteLine("There are no items in this room!");
            }
        }
        public static void myInventory(Avatar avatarInfos)
        {
            if (avatarInfos.inventory.Count > 0)
            {
                foreach (var i in avatarInfos.inventory)
                {
                    Console.WriteLine("Inventar: " + i.title);
                }
            }
            else
            {
                Console.WriteLine("Your bag is empty!");
            }
        }

        public static void dropItem(string words, Location location, Avatar avatarInfos)
        {
            if (avatarInfos.inventory.Count > 0)
            {
                Items foundItem = avatarInfos.inventory.Find(x => x.title.Contains(words));
                location.items.Find(x => x.title.Contains(words));
                avatarInfos.inventory.RemoveAll(x => x.title == words);
                location.items.Add(foundItem);
                myInventory(avatarInfos);
            }
            else
            {
                Console.WriteLine("There is nothing in your bag.");
            }

        }


    }
}