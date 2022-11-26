using System;

namespace Parameters
{

    class Example
    {
        static void Main(string[] args)
        {
            int[] fibonacciNumbers = GenerateFibonacciNumbers(10);
            Print(fibonacciNumbers);
        }


        private static void Print<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }


       static int[] GenerateFibonacciNumbers(int length)
        {
            int[] fibonacciNumbers = new int[length];
            
            fibonacciNumbers[0] = fibonacciNumbers[1] = 1;

            for (int i = 2; i < length; i++)
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];

            return fibonacciNumbers;
        }

    }
}
