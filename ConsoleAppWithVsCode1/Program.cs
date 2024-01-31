using System;


//To take input from command line arguments
namespace A;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!");
        Console.ReadLine();
    }

}


