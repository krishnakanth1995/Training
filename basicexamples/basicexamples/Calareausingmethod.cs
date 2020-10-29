using System;


namespace basicexamples
{
    class Calareausingmethod
    {
        int L = 50, B = 60;
        void SArea()

        {
            Console.WriteLine("Area of square :{0}", (L * L));

            Console.WriteLine("Area of recatangle :{0}", (L*B));
        }

        static void Main()
        {
            Calareausingmethod objcal = new Calareausingmethod();
            objcal.SArea(); 

           Console.ReadKey();


        }

       
    }  
}
    
    

