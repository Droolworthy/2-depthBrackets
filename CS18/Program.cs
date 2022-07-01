using System;

namespace CS18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "()";
            int maximumNestingDepth = 0;

            foreach (char symbol in text)
            {
                if (symbol == '(')
                    maximumNestingDepth++;
                
            
                if (symbol == ')')
                    maximumNestingDepth--;
                

            if (maximumNestingDepth == 0)
            {
                Console.WriteLine($"Корректное выражение. Макс глубина вложенности - {maximumNestingDepth}");
            }
            else
                Console.WriteLine("Некорректное выражение.");
        }
    }
}
