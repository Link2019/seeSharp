using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6
{
    class Program
    {
        static void Main(string[] args)
        {
            //97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
            string[] s = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            Rev(s);
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadKey();
        }
        public static void Rev(string[] s)
        {
            for(int i=0;i<s.Length;i++)
            {
                string temp = s[i];
                s[i] = s[s.Length - i-1];
                s[s.Length - i-1] = temp;
            }
        }
    }
}
