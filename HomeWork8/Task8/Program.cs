﻿namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,100));
            }
        }
    }
}
