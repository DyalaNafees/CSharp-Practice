using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("         |");
            for (int j = 0; j < 3; j++)
            {
                Console.Write("  |");

            }
            Console.WriteLine();
        }
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write("         |");
            for (int j = 0; j < 3; j++)
            {
                Console.Write("  |");

            }
            Console.WriteLine();
        }

    }
}