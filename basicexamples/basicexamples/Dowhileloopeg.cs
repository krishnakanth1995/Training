using System;


namespace basicexamples
{
    class Dowhileloopeg
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("Enter number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue > endvalue)
            {
                Console.WriteLine("inside while");
            }
            do
            {
                Console.WriteLine("inside do while");
                Console.WriteLine("initial value : {0}", initialvalue);
                initialvalue++;
            } while (initialvalue > endvalue);

            Console.ReadKey();
        }
        
    }
}
