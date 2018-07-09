using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swd_projekt
{
    class RandomNumber
    {
        static Random rnd = new Random();
        public static int attackPlayerValue()
        {
           int attackPlayer = rnd.Next(0, 20);
           return attackPlayer;
        }
        public static int attackEnemyValue()
        {
           int attackEnemy = rnd.Next(0, 10); 
           return attackEnemy;
        }
        
    }
       

}