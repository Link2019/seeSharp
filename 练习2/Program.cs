using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //79、用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },
            //请输出最长的字符串。
            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string s = "123134";
            //Console.WriteLine(s.Length);
            string max = GetLongest(names);
            Console.Write(max);
            Console.ReadKey();
        }
        
        public static string GetLongest(string[] s)
        {
            int n;
            string max = s[0];
            for (int i=0;i<s.Length;i++)
            {
                if(s[i].Length>max.Length)
                {
                    max = s[i];
                }
                
            }
            return max;
        }
        
    }
}
