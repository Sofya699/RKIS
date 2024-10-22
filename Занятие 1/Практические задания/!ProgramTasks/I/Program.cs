using System;

namespace I
{
    internal class Program
    {
        static string GetLastHalf(string text)
        {
            
            int startIndex = text.Length / 2;

        
            {
                startIndex++;
            }

            
            return text.Substring(startIndex);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!")); // "CSharp!"
            Console.WriteLine(GetLastHalf("1234567890"));     // "567890"
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си")); // "фа соль ля си"
        }
    }
}
