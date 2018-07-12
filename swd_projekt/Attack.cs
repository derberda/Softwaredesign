using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Attack
    {
        public static void Fight(Location location, Avatar avatarInfos, Enemy enemyInfos)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The " + enemyInfos.name + "is in the house - You have fight!");
            Console.WriteLine("who do you want to attack?:");
            string attackPerson = Console.ReadLine();
            Console.WriteLine("1. for test: " + enemyInfos.health + " , " + avatarInfos.health);
            for (; ; )
            {
                if (attackPerson == enemyInfos.name)
                {
                    enemyInfos.health = enemyInfos.health - RandomNumber.attackPlayerValue();
                    avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
                    Console.WriteLine("Kampf health Enemy: " + enemyInfos.health);
                    Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);

                }
                else if (attackPerson != enemyInfos.name)
                {
                    Console.WriteLine("This enemy does not exist! ");
                    avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
                    Console.ForegroundColor = ConsoleColor.White;
                    enemyInfos.health = enemyInfos.health - RandomNumber.attackPlayerValue();
                    Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);
                    Console.WriteLine("Kampf health Enemy: " + enemyInfos.health);
                }
                if (avatarInfos.health < 0)
                {
                    Console.WriteLine("You're dead - GAME OVER!");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                }
                if (enemyInfos.health < 0)
                {
                    enemyInfos.dead = true;
                    Enemy.randomLocation = -1;
                    Console.WriteLine("Suuupii du hast ihn gekillt. Er hatte Frau und Kinder!!");
                    dropLoot(location, enemyInfos);
                    Console.ResetColor();
                    break;
                }

            }
        }
        public static void dropLoot(Location location, Enemy enemyInfos)
        {
            if (enemyInfos.dead == true)
            {
                foreach (var i in enemyInfos.inventory)
                {
                    location.items.Add(i);
                }
                Console.WriteLine("Look there!! Your enemy dropped some items!");
            }

        }
    }
}
