using System;

namespace Parameters
{
    class Example
    {
        static void Main(string[] args)
        {
            int[] values = new int[5] { 6, 31, 1, 45, 54 };
            BubbleSort(values);
            Print(values);
        }


        private static void Print<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int cachedElement = array[i];
                        array[i] = array[j];
                        array[j] = cachedElement;
                    }
                }
            }
        }

    }
}
