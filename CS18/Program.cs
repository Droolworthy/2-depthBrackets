//Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением. Определить максимальную глубину вложенности скобок.
//Пример “(()(()))” -строка корректная и максимум глубины равняется 3.
//Пример не верных строк: "(()", "())", ")(", "(()))(()"
//Для перебора строки по символам можно использовать цикл foreach, к примеру будет так foreach (var symbol in text)
//Или цикл for(int i = 0; i < text.Length; i++) и дальше обращаться к каждому символу внутри цикла как text[i]
//Цикл нужен для перебора всех символов в строке.
using System;

namespace CS18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int maximumNestingDepth = 0;
            int deep = 0;

            foreach (char symbol in text)
            {
                if (symbol == '(')
                    deep++;

                if (deep > maximumNestingDepth)
                    maximumNestingDepth++;

                if (symbol == ')')
                    deep--;

                if (deep < 0)
                {
                    break;
                }
            }

            if (deep == 0)
            {
                Console.WriteLine($"Корректное выражение. Макс глубина вложенности - {maximumNestingDepth}");
            }
            else
                Console.WriteLine("Некорректное выражение.");
        }
    }
}
