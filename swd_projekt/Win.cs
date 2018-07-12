using System;
using System.Collections.Generic;

namespace swd_projekt
{
    class Win
    {
        public static void checkWin(Location location, Avatar avatarInfos)
        {
            if (location.title == "The backyard")
            {
                if (avatarInfos.inventory.Exists(x => x.title == "plier"))
                {
                    Console.WriteLine("You have won!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You can't get over the fences. Search for an Item that could help you!");
                }
            }
        }

    }

}