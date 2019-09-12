using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字 计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小 就重新输入
            Console.WriteLine("请输入第一个数字：");
            string n1 = Console.ReadLine();
            int m1=Judge(n1);
            Console.WriteLine("请输入第二个数字：");
            string n2 = Console.ReadLine();
            int m2=Judge(n2);
            JudgeMax(m1, m2);
            int sum = GetSum(m1, m2);
            Console.WriteLine("整数的和：" + sum);
            Console.ReadKey();

        }
        public static void JudgeMax(int n1, int n2)
        {
            if(n1<n2)
            {
                return;
            }
            else
            {
                Console.WriteLine("第一个数字必须比第二个数字小,请重新输入!");
                string a1 = Console.ReadLine();
                int m1 = Judge(a1);
                Console.WriteLine("请输入第二个数字：");
                string a2 = Console.ReadLine();
                int m2 = Judge(a2);
            }
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
                    Console.WriteLine("输入错误！请再次输入");
                    n = Console.ReadLine();
                    Judge(n);
                }
            }
        }
        public static int GetSum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
