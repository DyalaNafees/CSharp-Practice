using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        string[] lyrics ={
            "But I feel so seen in the night",
            "So, for now, it's only me",
            "And maybe that's all I need."
        };
        foreach (string l in lyrics)
        {
            for (int i = 0; i < l.Length; i++)
            {
                Console.Write(l[i]);
                Thread.Sleep(55);
            }
            Thread.Sleep(1900);
            Console.WriteLine("");
        }
    }
}