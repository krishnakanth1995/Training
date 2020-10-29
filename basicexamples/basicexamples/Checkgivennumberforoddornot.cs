using System;


namespace basicexamples
{
    class Checkgivennumberforoddornot
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter num");
            
            num = Convert.ToInt32(Console.ReadLine());
            if (num %2 == 0)
            {
                Console.WriteLine("number is not odd : {0}", num);
            }
            else
            {
                Console.WriteLine("number is odd : {0}", num);

            }

            Console.ReadKey();
        }
    }
}
