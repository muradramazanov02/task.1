using System;
using System.Runtime.Serialization.Formatters;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            for (int i = 1; i < (x + 1); i++)
            {
                if (x % i == 0)
                {
                    y++;

                }




            }
            if (y == 2)
            {
                Console.WriteLine("sade");

            }
            else
            {
                Console.WriteLine("murekkeb");
            }
            

        }
    }
}