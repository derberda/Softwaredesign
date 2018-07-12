using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Character
    {
        public string name;
        public int health;
        public bool dead;
        public static List<Items> inventory = new List<Items>();


    }
    class Avatar : Character
    {
        public static int playerLocation;

        public Avatar(int _health)
        {
            health = _health;
        }
        public static Avatar AvatarSetUp()
        {
            Avatar avatar = new Avatar(
                100
            );
            return avatar;
        }

    }
    class Enemy : Character
    {
        public static int randomLocation = 1;

        public Enemy(string _name, int _health, bool _dead)
        {
            name = _name;
            health = _health;
            dead = _dead;
        }
        public static Enemy EnemySetUp()
        {
            Enemy shopkeeper = new Enemy(
                "shopkeeper",
                100,
                false

            );
            return shopkeeper;
        }
    }


}