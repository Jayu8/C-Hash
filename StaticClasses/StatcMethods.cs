using System;

namespace ConsoleApp
{
    class Program
    {

        const int Value1 = 12;
        const int Value2 = 24;

        static void Main(string[] args)
        {

            int total = Add(Value1, Value2);
            Console.WriteLine("Total: " + total);

            int result;
            
            //Here also the out keyword need to be specified to tell it is by reference
            AddToOutParam(Value1, Value2, out result);
            Console.WriteLine("The answer is " + result);
        }
        //Method 1
        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        //Method 2 
        
        // out keyword means we expect the arguement to be passed in by reference. here it is result
        static void AddToOutParam(int value1, int value2, out int result)
        {
            result = value1 + value2;
        }
    }
}
