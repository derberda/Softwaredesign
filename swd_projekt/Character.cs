using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Character
    {
        public string name;
        public int health;
        public bool dead;
        public List<Items> inventory = new List<Items>();
    }

    class Avatar : Character
    {
        public int playerLocation;

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
          public int AvatarCurrentLocation(Location location,  Avatar avatarInfos, Enemy enemyInfos)
        {
            playerLocation = location.roomNumber;
            Enemy.EnemyRandomLocation(location, avatarInfos, enemyInfos);
            return playerLocation;
        }
        // public int setAvatarRoom(Location location, Avatar avatarInfos, Enemy enemyInfos)
        // {
        //     playerLocation = location.roomNumber;
            

        //     return playerLocation;
        // }

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
            Items money = new Items("money", "It's raining money yeah!!");
            shopkeeper.inventory.Add(money);

            return shopkeeper;
        }
        public static void EnemyRandomLocation(Location location, Avatar avatar, Enemy enemy)
        {
            
            if (enemy.dead == false)
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
        }
    }


}