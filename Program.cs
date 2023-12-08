using System;

namespace Pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            var number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    if (j > i)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
