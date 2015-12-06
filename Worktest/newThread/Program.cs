using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace newThread
{
    class Program
    {
        static  void Main(string[] args)
        {

            Thread t = new Thread(newthread);
            t.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("主线程2秒");
            //    Thread.Sleep(2000);
            //}
            Console.WriteLine("finished");
            Console.ReadKey();

        }
        static void newthread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("新线程4秒");
                Thread.Sleep(4000);
            }
        }
    }
}
