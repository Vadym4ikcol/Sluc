using System;
using System.Text;

namespace RandomStringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            string randomString = GenerateRandomString(length);
            Console.WriteLine($"Случайные символы: {randomString}");
        }

        static char GenerateRandomChar()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int index = rand.Next(chars.Length);
            return chars[index];
        }

        static string GenerateRandomString(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(GenerateRandomChar());
            }
            return sb.ToString();
        }
    }
}
