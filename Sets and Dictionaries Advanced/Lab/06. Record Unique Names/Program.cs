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
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
