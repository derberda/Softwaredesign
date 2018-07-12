using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swd_projekt
{
    class Attack
    {
        public static Enemy infos = Enemy.EnemySetUp();
        public static Avatar avatarInfos = Avatar.AvatarSetUp();
        
        #region h
        // public static void Fight(Enemy infos, Avatar avatarInfos)
        // {

        //     Console.WriteLine("who do you want to attack?:");
        //     string attackPerson = Console.ReadLine();
        //     Console.WriteLine("1. for test: " + infos.health +" , " + avatarInfos.health);
        //     if (attackPerson == infos.name)
        //     {
        //         for (; ; )
        //         {
        //             infos.health = infos.health - RandomNumber.attackPlayerValue();
        //             avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
        //             Console.WriteLine("Kampf health Enemy: " + infos.health);
        //             Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);
                    
        //             checkDeath(infos, avatarInfos);

        //         }
        //     }
        //     else
        //     {
        //         for (; ; )
        //         {
        //             Console.WriteLine("This enemy does not exist in this room!!");
        //             avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
        //             infos.health = infos.health - RandomNumber.attackPlayerValue();
        //             Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);
        //             Console.WriteLine("Kampf health Enemy: " + infos.health);
        //             checkDeath(infos, avatarInfos);

        //         }

        //     }
        //     // Console.ResetColor();
        // }
        // public static void checkDeath(Enemy infos, Avatar avatarInfos)
        // {

        //     for (; ; )
        //     {
        //         Console.WriteLine("test: " + avatarInfos.health +" , " + infos.health);
        //         if (avatarInfos.health < 0)
        //         {
        //             Console.WriteLine("You're dead - GAME OVER!");
        //             Console.ResetColor();
        //             Environment.Exit(0);
        //             break;

        //         }


        //         if (infos.health < 0)
        //         {
        //             infos.dead = true;
        //             Enemy.randomLocation = -1;
        //             Console.WriteLine("Suuupii du hast ihn gekillt. Er hatte Frau und Kinder!!");

        //             Console.ResetColor();
        //             break;

        //         }
        //         if (infos.health >0 && avatarInfos.health > 0)
        //             Fight(infos, avatarInfos);
        //     }

        // }
        #endregion
        #region neu


        public static void Fight()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The " + infos.name + "is in the house - You have fight!");
            Console.WriteLine("who do you want to attack?:");
            string attackPerson = Console.ReadLine();
            Console.WriteLine("1. for test: " + infos.health + " , " + avatarInfos.health);
            for (; ; )
            {
                if (attackPerson == infos.name)
                {
                    infos.health = infos.health - RandomNumber.attackPlayerValue();
                    avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
                    Console.WriteLine("Kampf health Enemy: " + infos.health);
                    Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);

                }
                else if (attackPerson != infos.name)
                {
                    Console.WriteLine("This enemy does not exist! ");
                    avatarInfos.health = avatarInfos.health - RandomNumber.attackEnemyValue();
                    Console.ForegroundColor = ConsoleColor.White;
                    infos.health = infos.health - RandomNumber.attackPlayerValue();
                    Console.WriteLine("Kampf health Avatar: " + avatarInfos.health);
                    Console.WriteLine("Kampf health Enemy: " + infos.health);
                }
                if (avatarInfos.health < 0)
                {
                    Console.WriteLine("You're dead - GAME OVER!");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                }
                if (infos.health < 0)
                {
                    infos.dead = true;
                    Enemy.randomLocation = -1;
                    Console.WriteLine("Suuupii du hast ihn gekillt. Er hatte Frau und Kinder!!");
                    Console.ResetColor();
                    break;
                }


            }
        }
        #endregion
    }
}
