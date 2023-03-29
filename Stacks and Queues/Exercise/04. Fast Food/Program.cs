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
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] inputOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(inputOrders);
            Console.WriteLine(inputOrders.Max());
            while (queue.Count > 0 && totalQuantity >= 0)
            {
                int currentOrder = queue.Peek();
                if (totalQuantity - currentOrder < 0)
                {
                    break;
                }

                totalQuantity -= currentOrder;
                queue.Dequeue();

            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }


        }
    }
}
