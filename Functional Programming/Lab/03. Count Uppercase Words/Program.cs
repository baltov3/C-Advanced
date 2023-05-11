using System;
using System.Linq;

namespace educationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> IsStartWithCapital = w => char.IsUpper(w[0]);
            Console.WriteLine(string.Join("\n",words.Where(IsStartWithCapital)));
        }
    }
}
