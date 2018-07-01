using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Program
    { 
        static string[] map = { "Parkplatz", "", "Supermarkt", "Büro", "Kühlraum", "Hinterhof" };
        static bool[,] mapDirection = new bool[,] { { false, false, true, false }, { false, false, false, false }, { true, true, true, false }, { false, false, false, true }, { true, true, false, false }, { false, false, false, true } };

        static int playerLocation = 0;

        static void Main(string[] args)
        {
            for (; ; )
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "north":
                    case "n":
                        if (mapDirection[playerLocation, 0] == true)
                        {
                            playerLocation -= 2;
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "east":
                    case "e":
                        if (mapDirection[playerLocation, 1] == true)
                        {
                            playerLocation += 1;
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "south":
                    case "s":
                        if (mapDirection[playerLocation, 2] == true)
                        {
                            playerLocation += 2;
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "west":
                    case "w":
                        if (mapDirection[playerLocation, 3] == true)
                        {
                            playerLocation -= 1;
                        }
                        else
                        {
                            Console.WriteLine("There is no way! Choose another one!");
                        }
                        break;
                    case "take":
                    case "t":
                        takeItem();
                        break;
                    case "drop":
                    case "d":
                        dropItem();
                        break;
                    case "inventory":
                    case "i":
                        myInventory();
                        break;
                    case "look":
                    case "l":
                        lookAround();
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
                        Console.WriteLine("Verstehe ich nicht");
                        break;
                }
                Console.WriteLine("Du bist im: " + map[playerLocation]);

                if (map[playerLocation] == "Hinterhof")
                {
                    Console.WriteLine("You finished the Game!");
                }
            }
        }
        public static void takeItem()
        {
            // List<string> items = new List<string>();
        }
        public static void dropItem()
        {
            // List<string> items = new List<string>();
        }
        public static void myInventory()
        {
            // List<string> items = new List<string>();
        }
        public static void lookAround()
        {
            
        }
    }
}


