using System;

namespace MashtabRandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int scale = 10;
            int count = 5;

            int[] scaledRandomNumbers = GenerateScaledRandomNumbers(scale, count);
            Console.WriteLine("Масштабированные случайные числа:");
            foreach (int number in scaledRandomNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] GenerateScaledRandomNumbers(int scale, int count)
        {
            Random rand = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(1, 101) * scale;
            }

            return numbers;
        }
    }
}
