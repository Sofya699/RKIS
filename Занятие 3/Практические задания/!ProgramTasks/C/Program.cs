namespace C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            string paddedText = $" {text} ";  
            int width = paddedText.Length + 2;

            Console.WriteLine(new string('-', width));
            Console.WriteLine($"|{paddedText}|");
            Console.WriteLine(new string('-', width));
        }
    }
}