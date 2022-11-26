using System;

namespace Parameters
{

    class Example
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { -20, 1, 51, -85, -9 };

            CountPositiveAndNegativeNumbers(numbers, out int positive, out int negative);
            Console.WriteLine($"Положительные = {positive}; Отрицательные = {negative}");
        }


        private static void Print<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }

        static void CountPositiveAndNegativeNumbers(int[] array, out int positive, out int negative)
        {
            positive = negative = 0;
            foreach (int item in array)
            {
                if (item > 0)
                    positive++;
                if (item < 0)
                    negative++;
            }
        }

    }
}
