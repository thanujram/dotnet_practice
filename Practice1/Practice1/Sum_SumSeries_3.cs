using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Sum_SumSeries_3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Sum Series : " + Sum_SumSer3(number));
        }

        static int Sum_SumSer3(int n)
        {
            return ((n * (n + 1) * (n + 2)) / 6);
        }
    }
}
