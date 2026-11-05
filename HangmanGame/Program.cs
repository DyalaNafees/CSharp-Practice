using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========================\nWelcome to Hangman Game\n========================");
        Console.WriteLine("____\n|/   |\n|   \n|   \n|   \n|   \n|   \n|_____");
        Console.WriteLine("\n");
        Console.WriteLine("Guess a letter: _ _ _ _ _");

        string word = "tiger";
        int c = 0;
        char input = (char)Console.Read();

        if (input == word.ElementAt(0) || input == word.ElementAt(1) || input == word.ElementAt(2) || input == word.ElementAt(3) || input == word.ElementAt(4))
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (input == word[i])
                {
                    Console.Write(word[i] + " ");
                }
            }
        } while (c != 7)
        {

        }

    }
}