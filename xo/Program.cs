﻿using System;

namespace xo
{
    class Program
    {
        public static char[] gameData = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static int counter = 0;
        public static char[] turn = { 'X', 'O' };
        public static char player;
        public static int intInput;


        // public string p1 = "Player 1 ist dran. Auf welchem Feld wollen sie ein x setzen?";
        // public string p2 = "Player 2 ist dran. Auf welchem Feld wollen sie ein o setzen?";

        static void Main(string[] args)
        {
            Game();
        }
        public static void Game()
        {
            for (; ; )
            {
                if (counter % 2 == 0)
                {
                    player = turn[0];
                }
                else
                {
                    player = turn[1];
                }

                PrintField();
                Console.WriteLine("It's your turn player " + player + " . Where do you want to set it?");
                string input = Console.ReadLine();

                try
                {
                    intInput = Convert.ToInt32(input);

                    if (gameData[intInput - 1] == turn[0] || gameData[intInput - 1] == turn[1])
                    {
                        Console.WriteLine("You must write another number between 1 and 9! This one is already occupied:(");
                    }
                    else
                    {
                        counter++;
                        gameData[intInput - 1] = player;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You must write a number between 1 and 9!");
                }
                if (FullField())
                {
                    Console.WriteLine("It's a DRAW!");
                    break;
                }

                if (Win())
                {
                    Console.WriteLine("Player " + player + " won!");
                    break;
                }
            }
        }

        public static bool FullField()
        {
            if (counter >= 9)
            {
                return true;
            }
            return false;
        }

        public static bool Win()
        {
            if (gameData[0] == gameData[1] && gameData[0] == gameData[2]) { return true; }
            if (gameData[3] == gameData[4] && gameData[3] == gameData[5]) { return true; }
            if (gameData[6] == gameData[7] && gameData[6] == gameData[8]) { return true; }

            if (gameData[0] == gameData[3] && gameData[0] == gameData[6]) { return true; }
            if (gameData[1] == gameData[4] && gameData[1] == gameData[7]) { return true; }
            if (gameData[2] == gameData[5] && gameData[2] == gameData[8]) { return true; }

            if (gameData[0] == gameData[4] && gameData[0] == gameData[8]) { return true; }
            if (gameData[2] == gameData[4] && gameData[2] == gameData[6]) { return true; }
            return false;
        }

        public static void PrintField()
        {
            Console.WriteLine("|" + gameData[0] + "|" + gameData[1] + "|" + gameData[2] + "|");
            Console.WriteLine("|" + gameData[3] + "|" + gameData[4] + "|" + gameData[5] + "|");
            Console.WriteLine("|" + gameData[6] + "|" + gameData[7] + "|" + gameData[8] + "|");
        }
    }
}