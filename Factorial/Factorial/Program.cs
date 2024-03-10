using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 1;
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }
            Console.WriteLine(y);
        }
    }
}

