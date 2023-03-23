using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());
            while (stack.Count > 1)
            {
                int firstnum = int.Parse(stack.Pop());
                string action = stack.Pop();
                int secondnum = int.Parse(stack.Pop());
                if (action == "+")
                {
                    stack.Push((firstnum + secondnum).ToString());
                }
                if (action == "-")
                {
                    stack.Push((firstnum - secondnum).ToString());
                }
            }
            Console.WriteLine(stack.Peek());


        }
    }
}
