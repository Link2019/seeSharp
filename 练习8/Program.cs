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
            int n = Convert.ToInt32(Console.ReadLine());
            GetMax(n);
        }
        public static int GetMax(params int[] a)
        {
            while(true)
            {
                int max = 0;
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                return max;
            }
            
        }
    }
}
