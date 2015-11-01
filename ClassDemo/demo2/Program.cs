using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        //阶乘
        static int Factorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(10));
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }


            ArrayList al = new ArrayList();
            al.Add(new person());
            bool isint = al[0] is string;
            //var isintvalue=al as person;
            Console.WriteLine(isint);
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(2015123456, "zhangsan");
            bool ise = dic.ContainsKey(2015123456);
            //Console.WriteLine(isintvalue);
            Console.ReadKey();
        }
    }
    class person
    {
        public override string ToString()
        {
            return "this is a person class";
        }


    }

    class people
    {

    }
}
