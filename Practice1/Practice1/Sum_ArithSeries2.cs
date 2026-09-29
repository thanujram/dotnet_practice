using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_ArithSeries2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Initial Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Difference Number:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Iteration:");
            int n = Convert.ToInt32(Console.ReadLine());

            int Sum_ArithSeries = Sum_ASer(a, d, n);
            Console.WriteLine("Sum of Arithmetic Series : " + Sum_ArithSeries);

        }

        static int Sum_ASer(int a, int d, int n)
        {
            int sum = (n * (2 * a + (n - 1) * d)) / 2;
            return sum;
        }
    }
}
