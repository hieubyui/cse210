using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type your first name: ");
        string first = Console.ReadLine();

        Console.WriteLine("Type your last name: ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}