using System;

namespace Parameters
{

    class Example
    {
        /* Передача параметров - имя и возраст человека:
        static void Main(string[] args)
        {
            PrintUserInfo("Коля", 15);
        }

        static void PrintUserInfo(string name, int age)
        {
            Console.WriteLine($"Имя: {name}; Возраст: {age}");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        } */


        // Передача параметров по ссылке:
        static void Main(string[] args)
        {
            int x = 1;
            Increase(ref x);
        }

        static void Increase(int value)
        {
            value++;
            Console.WriteLine($"Значение внутри метода {value}");
        }

        static void Increase(ref int value)
        {
            value++;
            Console.WriteLine($"Значение внутри метода {value}");
        }


        static void PrintUserInfo(string name, int age)
        {
            Console.WriteLine($"Имя: {name}; Возраст: {age}");
        }
    }
}
