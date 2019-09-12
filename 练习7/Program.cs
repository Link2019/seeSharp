using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7、写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r
            Console.WriteLine("请输入圆的半径：");
            double r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("圆的面积是{0:0.00}，周长是{1:0.00}", GetArea(r), GetPerimeter(r));
            Console.ReadKey();
        }
        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r">圆的半径</param>
        /// <returns>返回圆的面积</returns>
        public static double GetArea(double r)
        {
            double area;
            area = Math.PI * r * r;
            return area;
        }
        /// <summary>
        /// 计算圆的周长
        /// </summary>
        /// <param name="r">圆的半径</param>
        /// <returns>返回圆的周长</returns>
        public static double GetPerimeter(double r)
        {
            double Perimeter;
            Perimeter = 2 * r * Math.PI;
            return Perimeter;
        }
    }
}
