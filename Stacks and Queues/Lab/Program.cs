using System;
using System.Collections.Generic;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var item in a)
            {
                stack.Push(item);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
