using System;
namespace H
{
    internal class Program
    {
        // Метод для вычисления квадрата числа
        private static int GetSquare(int number)
        {
            return number * number;
        }

        // Метод для вывода числа на консоль
        private static void Print(int value)
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }
    }
}
