using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < i+1; i++)
            {
                if (i % 2 == 1 && i % 3 == 2 && i % 4 == 3 && i % 5 == 4 && i % 6 == 5 && i % 7 == 6 & i%8 == 7 && i%9 ==8 && i%10==9)
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }
        }
    }
}
