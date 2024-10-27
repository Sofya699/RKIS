namespace H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
            public static void Print<T>(T item) => Console.WriteLine(item);
        public static long GetSquare(int number) => number * number;
        }
    }
}
