using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую круглые, квадратные и фигурные скобки");
            string s = Console.ReadLine();
            bool b = true;
            Stack<char> bracket = new Stack<char>();
            foreach (char i in s)
            {
                if (i == '(')
                {
                    bracket.Push(')');
                }
                if (i == '[')
                {
                    bracket.Push(']');
                }
                if (i == '{')
                {
                    bracket.Push('}');
                }
                if (bracket.Count > 0 && i == bracket.Peek())
                {
                    bracket.Pop();
                    continue;
                }
                if (i == ')' || i == ']' || i == '}' && bracket.Count == 0)
                {
                    b = false;
                }
            }
            if (bracket.Count == 0 && b == true)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}