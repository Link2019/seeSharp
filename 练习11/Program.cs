using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11、将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] s = { "梅西", "卡卡", "郑大世" };
            Change(s);
            Console.ReadKey();
        }
        public static void Change(string[] s)
        {
            for(int i=0;i<s.Length-1;i++)
            {
                Console.Write(s[i]+" | ");
            }
            Console.WriteLine(s[s.Length-1]);
        }
    }
}
