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
            int[,] matrix = new int[n,n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = inputNumber[col];
                }
            }


            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                leftSum += matrix[i, i];
                rightSum += matrix[i, matrix.GetLength(1) - 1 - i];

            }
            Console.WriteLine(Math.Abs(leftSum-rightSum));
           
        }
    }
}
