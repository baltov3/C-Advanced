using System;
using System.Linq;

namespace educationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string[] wirds = Console.ReadLine().Split();
            double[] price = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            price = price.Select(x => x * 1.20).ToArray();
            for (int i = 0; i < price.Length; i++)
            {
                Console.WriteLine($"{price[i]:f2}");
            }
        }
    }
}
