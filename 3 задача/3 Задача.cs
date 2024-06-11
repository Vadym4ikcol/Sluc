using System;

namespace GenericRandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int scale = 5;
            int count = 7;
            int rangeMin = 1;
            int rangeMax = 50;

            int[] randomNumbers = GenerateRandomNumbers(scale, count, rangeMin, rangeMax);
            Console.WriteLine("Случайные числа:");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] GenerateRandomNumbers(int scale, int count, int rangeMin, int rangeMax)
        {
            Random rand = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(rangeMin, rangeMax + 1) * scale;
            }

            return numbers;
        }
    }
}
