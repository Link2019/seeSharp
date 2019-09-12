using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8、计算任意多个数间的最大值（提示：params）。
            //int n = Convert.ToInt32(Console.ReadLine());
            int max = GetMax(1, 2, 3, 8, 4, 5, 6, 7);
            Console.WriteLine("最大值是：" + max);
            Console.ReadKey();
        }
        public static int GetMax(params int[] a)
        {
            while (true)
            {
                int max = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                return max;
            }

        }
    }
}
