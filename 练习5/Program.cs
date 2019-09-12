using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5
{
    class Program
    {
        static void Main(string[] args)
        {
            //95、接受输入后判断其等级并显示出来。判断依据如下：等级={优 （90~100分）；良 （80~89分）

            //；中 （60~69分）；差 （0~59分）；}
            Console.WriteLine("请输入分数：");
            int score = Convert.ToInt32(Console.ReadLine());
            GetLevel(score);
            Console.ReadKey();

        }
        public static void GetLevel(int score)
        {
            while(true)
            {
                if(score>=90 && score<=100)
                {
                    Console.WriteLine("优");
                    break;
                }
                else if(score>=80 && score<90)
                {
                    Console.WriteLine("良");
                    break;
                }
                else if(score>=60 && score <80)
                {
                    Console.WriteLine("中");
                    break;
                }
                else if(score>=0 && score<60)
                {
                    Console.WriteLine("差");
                    break;
                }
            }
             
        }
    }
}
