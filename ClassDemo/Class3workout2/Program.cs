using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3workout2
{
    class Program
    {
        static int[] path = { -1, 0, 0, 1, 2, 4, 3, 3, 5, 6 };
        static void Main(string[] args)
        {
            for (int i = 0; i < path.Length; i++)
            {
                Console.Write("从0到{0}:", i);
                getpath(path[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void  getpath(int p)
        {
            if (p==-1)
            {
                return;
            }
            else
            {
                getpath(path[p]);
                Console.Write(p+" ");
            }

        }
    }
}
