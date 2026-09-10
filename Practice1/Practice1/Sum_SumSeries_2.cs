using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_SumSeries_2
    {
        public static void Main(string[] Args)
        {
            

            Console.Write("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int Sum_SumSeries = sumSumSeries(num);

            Console.WriteLine("Sum of Sum Series : " + Sum_SumSeries);
        }

        static int sumSumSeries(int n)
        {
            int sumSumSer = 0;
            for (int i = n; i > 0; i--)
            {
                sumSumSer = sumSumSer + (i * (i + 1)) / 2;
            }
            return sumSumSer;
        }
    }
}
