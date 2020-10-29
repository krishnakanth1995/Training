using System;
using System.Runtime.CompilerServices;

namespace basicexamples
{
    class Forloopeg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine("Enter table");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());

            // for loop for(initilization;condition;increment/decrement)
            for (int i = 1; i <= n; i++)
            {
                int t = i * table;
                Console.WriteLine("{0}*{1}= {2}",table , n, t );
            }

            Console.ReadKey();
        }

            
    }
}
