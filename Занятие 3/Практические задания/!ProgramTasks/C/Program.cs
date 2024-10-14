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
            var lengthText = text.Length + 2;
            var patternWall = string.Concat(Enumerable.Repeat("-", lengthText)).ToString();
            var readyText = "| " + text + " |";

            Console.WriteLine("+" + patternWall + "+");
            Console.WriteLine(readyText);
            Console.WriteLine("+" + patternWall + "+");
        }
    }
}