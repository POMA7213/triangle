using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint h = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < h; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (uint i = h; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (uint i = h; i > 0; i--)
            {
                int j = 0;
                for (; j < i-1; j++)
                {
                    Console.Write(" ");
                }
                for(;j<h; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (uint i = 0; i < h; i++)
            {
                int j = 0;
                for (; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (; j < h; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
