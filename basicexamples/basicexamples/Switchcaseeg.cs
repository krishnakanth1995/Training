using System;

/*switch(case)
     * {
     * case 1: statements; break;
     * case 2:set of statements;break;;
     * 
     * case n:set of statements;break;
     * default:set of statements;break;
     }
         */


namespace basicexamples
{
    class Switchcaseeg
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine ("invaid entry");
                    break;

            }
            Console.ReadKey();
        }
    }
}
