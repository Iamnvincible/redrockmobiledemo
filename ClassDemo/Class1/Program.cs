using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            float b = 1.1f;
            float c = 1.2f;
            double d = 1.11;
            double e = 1.111d;
            long f = 12345;
            long g = 12345L;
            a = (int)b;
            b = a;
            d = b;
            b = (float)d;
            Console.WriteLine("{0}--{1}--{2}--{3}--{4}--{5}--{6}",a,b,c,d,e,f,g);
            Console.ReadLine();

        }
    }
}
