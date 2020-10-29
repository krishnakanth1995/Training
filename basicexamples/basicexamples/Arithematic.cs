using System;


namespace basicexamples
{
    class Arithematic
    {
        static void Main()
        { 
            int num1 = 20 , num2 = 30 ,result1, result2;
            result1 = num1 + num2;
            result2 = num2 - num1;

            Console.WriteLine("Addition : {0}", result1);
            Console.WriteLine("Subtraction : {0}", result2);

            Console.ReadKey();


        }
    }
}
