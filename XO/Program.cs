using System;
using System.Collections.Generic;
class Program
{
    static void board()
    {
        Console.WriteLine("┏━━━━━┳━━━━━┳━━━━━┓");
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write("┃  ");

                if (c == cursorCol && r == cursorRow)
                {
                    if (cell[r, c] == ' ')
                        Console.Write("_");
                    else
                        Console.Write(cell[r, c]);
                }
                else
                    Console.Write(cell[r, c]);
                Console.Write("  ");
            }
            Console.Write("┃");
            Console.WriteLine();
            if (r < 2)
                Console.WriteLine("┣━━━━━━━━━━━━━━━━━┫");
            else
                Console.WriteLine("┗━━━━━┻━━━━━┻━━━━━┛");
        }

    }
    static int cursorRow = 0;
    static int cursorCol = 0;
    static char player = 'X';
    static char[,] cell = new char[3, 3] {
            { ' ',' ',' '},
            { ' ',' ',' '},
            { ' ',' ',' '}
        };
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");

        while (true)
        {
            Console.Clear();
            board();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (cursorRow > 0)
                        cursorRow--;
                    break;
                case ConsoleKey.DownArrow:
                    if (cursorRow < 2)
                        cursorRow++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (cursorCol > 0)
                        cursorCol--;
                    break;
                case ConsoleKey.RightArrow:
                    if (cursorCol < 2)
                        cursorCol++;
                    break;
            }
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            if (userInput.Key.Equals(ConsoleKey.Enter)){
                cell[cursorRow, cursorCol] = 'X';
            }
        }
    }
}