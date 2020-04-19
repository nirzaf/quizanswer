using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < i+1; i++)
            {
                if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1 && i % 7 == 0)
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }
        }
    }
}
