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
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCount = 0;
            string commd = Console.ReadLine();
            while (commd != "end")
            {
                if (commd == "green")
                {
                    if (cars.Count == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < n && cars.Count > 0; i++)
                    {

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCount++;

                    }
                }
                else
                {
                    cars.Enqueue(commd);
                }
                commd = Console.ReadLine();
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");


        }
    }
}