using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_SumSeries
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter a Number:");
            int x = Convert.ToInt32(Console.ReadLine());

            
            int sum_sumSer = 0;


            for(int i = x; i > 0; i--)
            {
                int sumSer = 0;

                for (int j = i; j > 0; j--)
                {
                    sumSer = sumSer + j;
                }

                sum_sumSer = sum_sumSer + sumSer;
            }

            Console.WriteLine("Sum of Sum Series: " + sum_sumSer);

        }
    }
}
