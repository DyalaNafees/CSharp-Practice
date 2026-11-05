using System;
using System.Threading;

namespace DiceGame
{
    class Player
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerPoints = 0;
            int enemyPoints = 0;

            Console.WriteLine("Welcome to Dice Game!");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("===================================\n             ROUND " + i + "\n===================================");

                Console.WriteLine("Press any key to roll a dice...");

                Console.ReadKey();

                int playerNum = random.Next(1, 7);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You rolled : " + playerNum);

                System.Threading.Thread.Sleep(700);

                int enemyNum = random.Next(1, 7);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enemy rolled : " + enemyNum);

                System.Threading.Thread.Sleep(700);

                if (playerNum > enemyNum)
                {
                    playerPoints++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("You ");
                    Console.ResetColor();
                    Console.WriteLine("wins this round !");
                }
                else if (playerNum < enemyNum)
                {
                    enemyPoints++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Enemy ");
                    Console.ResetColor();
                    Console.WriteLine("wins this round !");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Draw!");
                }

                Console.ResetColor();
                System.Threading.Thread.Sleep(1500);
            }
            Console.WriteLine();
            if (playerPoints > enemyPoints)
            {
                string s = "Congrats! you win";
                foreach (var element in s)
                {
                    Console.Write(element);
                    Thread.Sleep(55);
                }
                Console.ResetColor();
            }
            else if (playerPoints < enemyPoints)
            {
                string s = "Game Over! you lose";
                foreach (var element in s)
                {
                    Console.Write(element);
                    Thread.Sleep(55);
                }
                Console.ResetColor();
            }
            else
            {
                string s = "Draw!";
                foreach (var element in s)
                {
                    Console.Write(element);
                    Thread.Sleep(55);
                }
            }
        }
    }
}