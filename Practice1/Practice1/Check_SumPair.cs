using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Check_SumPair
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, -1, 2, -3, 1};

            Console.Write("Enter Target:");
            int t = Convert.ToInt32(Console.ReadLine());

            check_Pair(arr, t);

        }

        static void check_Pair(int[] a, int t)
        {
            int n = a.Length;

            for(int i = 0; i < n - 1; i++)
            {
                Console.Write("a[i]:" + a[i] + " ");

                for(int j = i + 1; j < n - 1; j++)
                {
                    Console.Write("a[j]:" + a[j] + " ");

                    if (a[i] + a[j] == t)
                    {
                        Console.WriteLine("a[i] + a[j] = t -> " + a[i] + " + " + a[j] + " = " + t);
                        Console.WriteLine("Pair Found: " + a[i] + " & " + a[j]);
                        break;
                    }   
                }
            }
        }
    }
}
