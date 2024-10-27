using System;
using System.Collections.Generic;

namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменной message
            string message = "Писать буДу я тЕбЕ Код ХОРОШИЙ Код Трудно Ты НЕ Сдавайся Все Упрощать";

            // Разделение строки на слова
            string[] words = message.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var capitalizedWords = new List<string>();

            // Проверка каждого слова на заглавную букву
            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    capitalizedWords.Add(word);
                }
            }

            // Вывод слов с заглавной буквы в обратном порядке
            for (int i = capitalizedWords.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(capitalizedWords[i] + " "); // Писать буДу я тЕбЕ Код ХОРОШИЙ Код Трудно Ты НЕ Сдавайся Все Упрощать
            }
        }
    }
}
