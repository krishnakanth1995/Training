using System;
using System.Runtime.InteropServices;

namespace basicexamples
{
    class whileloopeg
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
           Console.WriteLine("Enter number");
           endvalue = Convert.ToInt32(Console.ReadLine());
           while (initialvalue<=endvalue)
           {

                 initialvalue++;
               if (initialvalue%2==0)
              {

                   Console.WriteLine("{0} is even ",  initialvalue);
              }
              else
              {
                   Console.WriteLine(" {0} is Not not even ", initialvalue);
              }

               Console.ReadKey();
           }


           
        }
    }
}
