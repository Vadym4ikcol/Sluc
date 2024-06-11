using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine($"Случайное число: {randomNumber}");
        }
    }
}
