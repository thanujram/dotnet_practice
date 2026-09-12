using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_ArithSeries
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Initial Number:");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Difference Number:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Iteration:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum_ArithSeries = Sum_ASer(i, d, n);
            Console.WriteLine("Sum of Arithmetic Series : " + sum_ArithSeries);
        }

        static int Sum_ASer(int i, int d, int n)
        {
            int sum = i;

            for (int x = n; x > 0; x--)
            {
                sum = sum + (i + (d * n));
            }

            return sum;
        }
    }
}
