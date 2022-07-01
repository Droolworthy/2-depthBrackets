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
