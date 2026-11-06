using System;
using System.Collections.Generic;
class Program
{
    public static void start()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("━━━━━━━");
    }
    public static void firstTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("━━━━━━━");
    }
    public static void secondTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃   |");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("━━━━━━━");
    }
    public static void thirdTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃  ᐠ|");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("━━━━━━━");
    }
    public static void forthTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃  ᐠ|⸍");
        Console.WriteLine("   ┃  ");
        Console.WriteLine("━━━━━━━");
    }

    public static void fifthTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃  ᐠ|⸍");
        Console.WriteLine("   ┃  ⸍ ");
        Console.WriteLine("━━━━━━━");
    }
    public static void lastTry()
    {
        Console.WriteLine("   ┏━━━┓");
        Console.WriteLine("   ┃   ⃝");
        Console.WriteLine("   ┃  ᐠ|⸍");
        Console.WriteLine("   ┃  ⸍ ᐠ");
        Console.WriteLine("━━━━━━━");
    }

    static void Main(string[] args)
    {
        int mistake = 0;


        List<string> words = new List<string> { "QUEEN", "SONG",
                "PARK", "HOCKEY", "BATTERY", "PASSWORD", "ELECTRICITY", "TOAST","PIZZA","PHOTOGRAPH" };

        string randomWords = words[Random.Shared.Next(words.Count)];

        char[] hiddenDisplay = new char[randomWords.Length];
        for (int i = 0; i < hiddenDisplay.Length; i++)
        {
            hiddenDisplay[i] = '_';
        }

        while (mistake != 6 && hiddenDisplay.Contains('_'))
        {
            Console.Clear();
            Console.WriteLine("\n===========================\n        Hangman Game\n===========================\n");
            switch (mistake)
            {
                case 0: start(); break;
                case 1: firstTry(); break;
                case 2: secondTry(); break;
                case 3: thirdTry(); break;
                case 4: forthTry(); break;
                case 5: fifthTry(); break;
                case 6: lastTry(); break;
            }

            Console.Write("\nGuess a letter : ");
            for (int i = 0; i < hiddenDisplay.Length; i++)
            {
                Console.Write(hiddenDisplay[i] + " ");
            }
            Console.WriteLine();
            string userInput = Console.ReadLine().ToUpper();
            char letter = userInput[0];

            if (randomWords.Contains(letter))
            {
                for (int i = 0; i < randomWords.Length; i++)
                {
                    if (randomWords[i] == letter)
                        hiddenDisplay[i] = letter;
                }
            }
            else
            {
                mistake++;
            }
        }
        Console.Clear();
        Console.WriteLine("\n===========================\n        Hangman Game\n===========================\n");
        switch (mistake)
        {
            case 0: start(); break;
            case 1: firstTry(); break;
            case 2: secondTry(); break;
            case 3: thirdTry(); break;
            case 4: forthTry(); break;
            case 5: fifthTry(); break;
            case 6: lastTry(); break;
        }

        Console.Write("\nGuess a letter : ");
        for (int i = 0; i < hiddenDisplay.Length; i++)
        {
            Console.Write(hiddenDisplay[i] + " ");
        }
        Console.WriteLine();

        if (mistake == 6)
        {
            Console.WriteLine("Game Over!\nThe Word is : " + randomWords);
        }
        else
        {
            Console.WriteLine("Congrats! You guessed the word");
        }
    }
}