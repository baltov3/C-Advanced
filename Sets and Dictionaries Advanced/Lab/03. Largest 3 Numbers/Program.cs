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
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            int[] ordered = n.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(String.Join(" ", ordered));
        }

    }
}
