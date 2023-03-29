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
          int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>(); 
            for (int i = 0; i <n ; i++)
            {
                int[] inptu = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(inptu);

            }
            int startIndex = 0;
           
         

            while (true)
            {
                int totallitters = 0;
                bool isComplate = true;
                foreach (var item in queue)
                {
                   
                    int litters = item[0];
                    int distance = item[1];
                    totallitters += litters;
                    if (totallitters - distance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isComplate = false;
                        break;
                    }
                    totallitters -= distance;
                    
                }
                if (isComplate)
                {
                    Console.WriteLine(startIndex);
                    break;
                }

            }


        }
    }
}
