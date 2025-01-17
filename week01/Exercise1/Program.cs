using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name?");
        string first = Console.Readline();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"your name is {last}, {first} {last}.");
        
    }
}