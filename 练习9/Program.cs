using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            int[] arr = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            MySort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 冒泡排序法
        /// </summary>
        /// <param name="arr">整数数组</param>
        public static void MySort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }
    }
}
