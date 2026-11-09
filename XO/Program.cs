using System;
using System.Threading;
using System.Collections.Generic;


class Program
{
    static Random random = new Random();
    static int cursorRow = 0;
    static int cursorCol = 0;

    static char[,] cell = new char[3, 3] {
            { ' ',' ',' '},
            { ' ',' ',' '},
            { ' ',' ',' '}
        };
    static void Board()
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
    static void Player2()
    {
        int rowLoc = random.Next(0, 3);
        int colLoc = random.Next(0, 3);

        if (cell[rowLoc, colLoc] == ' ')
        {
            cell[rowLoc, colLoc] = 'O';
        }
        else if (!Full())
            Player2();
    }
    static bool Full()
    {
        bool isFull = true;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (cell[i, j] == ' ')
                    isFull = false;
            }
        }
        return isFull;
    }
    static bool CheckWin()
    {
        bool winner = false;
        if (cell[0, 0] != ' ' && cell[0, 0] == cell[1, 1] && cell[1, 1] == cell[2, 2])
        {
            winner = true;
            Console.WriteLine(cell[0, 0] + " Wins!");
        }
        else if (cell[0, 2] != ' ' && cell[0, 2] == cell[1, 1] && cell[1, 1] == cell[2, 0])
        {
            winner = true;
            Console.WriteLine(cell[0, 2] + " Wins!");
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                if (cell[0, i] != ' ' && cell[0, i] == cell[1, i] && cell[1, i] == cell[2, i])
                {
                    winner = true;
                    Console.WriteLine(cell[0, i] + " Wins!");
                    break;
                }
                else if (cell[i, 0] != ' ' && cell[i, 0] == cell[i, 1] && cell[i, 1] == cell[i, 2])
                {
                    winner = true;
                    Console.WriteLine(cell[i, 0] + " Wins!");
                    break;
                }
            }
        }
        return winner;
    }
    static bool won = CheckWin();

    public static void Main(string[] args)
    {
        while (!won && !Full())
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Board();
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
                case ConsoleKey.Enter:
                    if (cell[cursorRow, cursorCol] == ' ')
                    {
                        cell[cursorRow, cursorCol] = 'X';
                        won = CheckWin();
                        if (!won)
                        {
                            Player2();
                        }
                    }
                    break;
            }
        }
        Console.Clear();
        Board();
    }
}