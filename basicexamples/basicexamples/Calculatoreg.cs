using System;


namespace basicexamples
{
    class Calculatoreg
    {
        // creating global variable in class, so scope is through out the class
        float num1 = 30, num2 = 20, result;
        // method without return type
        void Add()
        { // variable local to the method, so scope is within this void function
            // float num1 = 30 , num2= 20, result;

            // extra space is created for variable result
            result = num1 + num2;

              Console.WriteLine("Add:{0}", result);
            // efficient way to write 
            Console.WriteLine("Add:{0}", (num1 + num2));

            

        }
        // method with return type 
        float sub()
        {
            return (num1 - num2);
            // return only returns value but not prints so seperate variable is to 
            //be created to store and print

        }

        static void Main()
        {
            // object creation

            Calculatoreg objcalci = new Calculatoreg();
            objcalci.Add();

            float res = objcalci.sub();
            Console.WriteLine("sub:{0}", res);
            // optimized way
            Console.WriteLine("sub:{0}", objcalci.sub());
            Console.ReadKey();
        }


        
    }
}
