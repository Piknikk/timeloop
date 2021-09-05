using System;

namespace timeloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int x = 1; x <= number; x++)
                Console.WriteLine(x + " Abracadabra");

        }
    }
}
