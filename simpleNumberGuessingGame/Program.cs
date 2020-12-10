using System;
using System.Linq;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int numToGetCloseTo = rnd.Next(1, 10);
            int cpuNum = rnd.Next(1, 10);

            Console.WriteLine("Play ClosestToTheNumber\n" + "Enter a number between 1-10");

            int userNum = Convert.ToInt32(Console.ReadLine());

            while (Enumerable.Range(1, 10).Contains(userNum) == false)
            {
                Console.WriteLine("Try again. Enter a number between 1-10");
                userNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Your number: {userNum}\n" +
                $"CPU Number: {cpuNum}\n" +
                $"Number To Guess At: {numToGetCloseTo}"
                );

            int userPoints = Math.Abs(userNum - numToGetCloseTo);
            int cpuPoints = Math.Abs(cpuNum - numToGetCloseTo);

            if (userPoints < cpuPoints)
            {
                Console.WriteLine("You Won!");
            } else if (cpuPoints < userPoints)
            {
                Console.WriteLine("Cpu Won...");
            } else
            {
                Console.WriteLine("You Tied with Cpu");
            }
        }
    }
}