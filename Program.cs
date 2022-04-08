
using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Display(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Input the Limit of natural number");
            int n = Convert.ToInt32(Console.ReadLine());
            Display(n);


        }
    }
}
