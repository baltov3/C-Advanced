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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toPuch = numbers[0];
            int toPop = numbers[1];
            int x = numbers[2];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < toPuch; i++)
            {
                stack.Push(inputNumbers[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
