using Microsoft.Win32;
using System;


namespace basicexamples
{
    class Switchcaseeg2
    {
        static void Main()
        {
            int num1, num2, result;
            string opeartion;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("write opereation to be performed ");
            opeartion = Console.ReadLine();
            switch(opeartion)
            {
                case "ADD ":
                    
                result = num1 + num2;
                    Console.WriteLine(" addition : {0}", result);
                break;

                case "SUB":
                    result = num1 - num2;
                    Console.WriteLine(" substaraction : {0}", result);
                    break;
                default:
                    result = num1 * num2;
                    Console.WriteLine(" multiplication : {0}", result);
                    break;
            }

            Console.ReadKey();

        }
    }
}
