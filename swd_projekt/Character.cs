using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Character
    {
        public static string name;
        public static int health1;
        public static int health2;
        public static bool dead;
        public static List<string> inventory = new List<string>();
    }
    class Avatar : Character
    {
        public static int playerLocation;

    }
    class Enemy : Character
    {
        public static int randomLocation = 1;
    }
}