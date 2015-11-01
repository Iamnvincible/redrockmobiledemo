using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower
{
    /// <summary>
    /// 汉诺塔
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';
            int n = 20;
            H(a, b, c, n);
            Console.ReadKey();
        }
        static void Move(char x,char y)
        {
            Console.WriteLine("从{0}移动到{1}", x, y);
        }
        /// <summary>
        /// 通过y,把x上的n个盘子移动到z上
        /// </summary>
        /// <param name="x">Source</param>
        /// <param name="y">temp</param>
        /// <param name="z">Destination</param>
        /// <param name="n">盘子的数量</param>
        static void H(char x, char y ,char z,int n)
        {
            if (n == 1)
            {
                Move(x, z);
            }
            else
            {
                H(x, z, y, n - 1);
                Move(x, z);
                H(y, x, z, n - 1);
            }
        }
    }
}
