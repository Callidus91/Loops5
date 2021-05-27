using System;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine(j * 1111);
                }
                Console.WriteLine();
            }
        }
    }
}
