using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalance = true;
            foreach (var item in input)
            {
                if (item=='{'||item== '('||item =='[')
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count==0)
                {
                    isBalance = false;
                    break;
                }
                if (item == '}' && stack.Peek() =='{')
                {
                    stack.Pop();
                }
                else if (item == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
               else if (item == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    isBalance = false;
                    break;
                }
            }
            if (!isBalance||stack.Count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}
