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
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] students = Console.ReadLine().Split();
                string studentName = students[0];
                decimal grade = decimal.Parse(students[1]);
                if (!result.ContainsKey(studentName))
                {
                    result.Add(studentName, new List<decimal>());
                }
                 
               
                result[studentName].Add(grade);
            }
            foreach (var item in result)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }

        }

    }
}
