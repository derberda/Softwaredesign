using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swd_projekt
{
    class Attack
    {
        
        public static void Fight()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The shopkeeper is in the house - You have fight!");
            Console.WriteLine("Attack on Titan");
            Avatar.health1 = 100;
            Enemy.health2 = 100;
            Enemy.name = "shopkeeper";
            Console.WriteLine("who do you want to attack?:");
            string attackPerson = Console.ReadLine();
            if(attackPerson == Enemy.name)
            {
                for(;;)
                {
                    Avatar.health1 = Avatar.health1 - RandomNumber.attackEnemyValue();    
                    Enemy.health2 = Enemy.health2 - RandomNumber.attackPlayerValue(); 
                    Console.WriteLine("Kampf health Avatar: " + Avatar.health1);
                    Console.WriteLine("Kampf health Enemy: " + Enemy.health2);   
                    if(Avatar.health1 < 0)
                    {
                        Console.WriteLine("You're dead - GAME OVER!");
                        Environment.Exit(0);
                        break;
                    }
                    if(Enemy.health2 < 0)
                    {
                        Enemy.dead = true;
                        Console.WriteLine("Suuupii du hast ihn gekillt. Er hatte Frau und Kinder!!");
                        break;
                    }
                }
                // Console.ForegroundColor = ConsoleColor.DarkMagenta;
                // Console.WriteLine("Anfangs health: " + Avatar.health1);
                // Console.WriteLine("Anfangs health: " + Enemy.health1);
                 
                // Console.WriteLine("Kampf health: " + Avatar.health1);
                // Console.WriteLine("Kampf health: " + Enemy.health2);       
            }
            else
            {
                Console.WriteLine("This enemy does not exist in this room!!");
            }
            Console.ResetColor();
        }
           
    }

}
