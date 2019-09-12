using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10、用方法来实现：请计算出一个整型数组的平均值。
            //{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。
            //要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
            int[] arr = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            double ave = GetAve(arr);
            Console.WriteLine("整形数组的平均值是：{0:0.00}", ave);
            Console.ReadKey();

        }

        public static double GetAve(int[] arr)
        {
            double sum=0;
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            double ave = 1.0*sum / arr.Length;
            return ave;
        }
    }
}
