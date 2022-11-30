using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(name);
            int tosscountToRemove = int.Parse(Console.ReadLine());
            int currentTosses = 1;
            while (queue.Count > 1)
            {
                var kindWithPateto = queue.Dequeue();
                if (currentTosses != tosscountToRemove)
                {
                    currentTosses = 1;
                    queue.Enqueue(kindWithPateto);

                }
                else
                {
                    Console.WriteLine($"Removed {kindWithPateto}");
                    currentTosses++;
                }

            }
            Console.WriteLine($"Lasr is {queue.Dequeue()}");
        }
    }
}
