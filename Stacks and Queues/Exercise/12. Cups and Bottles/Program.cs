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
         
            int[] inpuCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            Stack<int> bottels = new Stack<int>(inputBottles);
            Queue<int> cups = new Queue<int>(inpuCups);
            int wastedlitters = 0;

            while (bottels.Count>0&&cups.Count>0)
            {
               int currentBottels= bottels.Pop();
                int currentCups = cups.Dequeue();
                if (currentBottels-currentCups>=0)
                {
                    wastedlitters += currentBottels - currentCups;
                  
                    continue;
                }
                currentCups -= currentBottels;
                while (currentCups>0&&bottels.Count>0)
                {
                    int bottel = bottels.Pop();
                    if (bottel>=currentCups)
                    {
                        wastedlitters += bottel- currentCups;
                        break;
                    }
                    currentCups-= bottel;
                }
            }
            if (bottels.Count>0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottels)}");
                Console.WriteLine($"Wasted litters of water: {wastedlitters}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedlitters}");
            }
        }
    }
}
