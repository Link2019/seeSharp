using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            //81、写一个方法，用来判断用户输入的数字是不是质数 
            //再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入数字
            Console.WriteLine("请输入数字：");
            string num1 = Console.ReadLine();
            int n = Judge(num1);
            bool b = ZhiShu(n);
            if (b)
                Console.WriteLine("{0}是质数", n);
            else Console.WriteLine("{0}不是质数", n);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断是否是质数
        /// </summary>
        /// <param name="n">用户输入的数</param>
        /// <returns>返回bool值</returns>
        public static bool ZhiShu(int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0) return false;
                }
            }
            return true;
        }
        public static int Judge(string n)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(n);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入的不是数字！请重新输入！");
                    n = Console.ReadLine();
                    Judge(n);
                }
            }

        }
    }
}
