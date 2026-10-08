using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write ("Enter Your Name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            float maxHealth = 150;

            Console.WriteLine("Enter Your Weapon");
            string weapon = Console.ReadLine();
            Console.WriteLine($"Your Health Now, {maxHealth}!");
            Console.WriteLine($"Your Weapon Now, {weapon}!");

            Console.WriteLine("1 - Left");
            Console.WriteLine("2 - Rigth");
            Console.Write("Enter Number for Your Journey");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("You Go to Left");
                    Console.WriteLine("You Lose");
                    break;
                
                case "2":
                    Console.WriteLine("You Go to Rigth");
                    Console.WriteLine("You moved on.");
                    break;

             Console.ReadKey();
            }
           ;
        }
    }
}
