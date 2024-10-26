using System;

namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            if (count % 100 >= 11 && count % 100 <= 19) // для чисел от 11 до 19
                return "рублей";
            if (count % 10 == 1) // для 1, 21, 31 и т.д.
                return "рубль";
            if (count % 10 >= 2 && count % 10 <= 4) // для 2, 3, 4, 22, 23, 24 и т.д.
                return "рубля";
            return "рублей"; // остальные случаи
        }
    }
}
