using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Iamastudent";
            string b = "Iamastudent";
            b = "kdsljdj";
            b += "jdlgj";
            for (int i = 'a'; i <='z'; i++)
            {
                char o = (char)i;
                char r = (char)(i + 1);
                a = a.Replace(o, r);
            }
            Console.WriteLine(a);
            StringBuilder sum=new StringBuilder();
            for(int i = 0; i < 99999; i++)
            {
                sum.Append(i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
