using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //80、用方法来实现：请计算出一个整型数组的平均值。
            int[] a = { 0, 1, 2, 2, 3, 4, 5 };
            double avg = GetAve(a);
            Console.WriteLine("平均值为：{0:0.00}", avg);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算一个整形数组的平均值
        /// </summary>
        /// <param name="a">整形数组</param>
        /// <returns>返回平均值</returns>
        public static double GetAve(int[] a)
        {
           int sum = 0;
           for(int i=0;i<a.Length;i++)
            {
                sum += a[i];
            }
            double avg =1.0* sum / a.Length;
            return avg;
        }
    }
}
