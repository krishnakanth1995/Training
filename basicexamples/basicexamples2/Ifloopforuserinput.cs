using System;


namespace basicexamples2
{
    class Ifloopforuserinput
    {
     static void Main()
        {
            int num1,num2,num3;
            Console.WriteLine("Enter num1");
            num1 =Convert. ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater:{0}", num1);

            }
            else if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine("num2 is greater : {0}", num2);

            }
            else
            {
                Console.WriteLine("num3 is greater : {0}", num3);
            }

            Console.ReadKey();

        }



    }
}
