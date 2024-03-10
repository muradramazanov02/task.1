using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("reqemi daxil edin: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("reqemi daxil edin: ");
        int y = Convert.ToInt32(Console.ReadLine());    

        int vurma = x * y;

        Console.WriteLine("cavab: " + vurma);
    }
}
