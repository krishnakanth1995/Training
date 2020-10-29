using System;


namespace basicexamples
{
    class Studentdetailsfromuser
    {
        static void Main()
        {
            string Studentname,location; int Rollno;

            Console.WriteLine("Enter Studentname");
            Studentname = Console.ReadLine();

            Console.WriteLine("Enter Location");
            location = Console.ReadLine();

            Console.WriteLine("Enter Rollno ");
            Rollno = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

          

        }
            
    }
}
