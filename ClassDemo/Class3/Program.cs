using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region stringbuilder和string
            string a = "0";
            DateTime t = DateTime.Now;
            Console.WriteLine("string开始：{0}", t.ToFileTime());
            for (int i = 0; i < 1000; i++)
            {
                a += i;
            }
            t = DateTime.Now;
            Console.WriteLine("string结束：{0}", t.ToFileTime());

            StringBuilder sb = new StringBuilder();
            DateTime t2 = DateTime.Now;
            Console.WriteLine("开始时间：{0}", t2.ToFileTime());
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            t2 = DateTime.Now;
            Console.WriteLine("结束时间：{0}", t2.ToFileTime());
            Console.WriteLine("完成");
            #endregion
            #region 集合/泛型集合
            ArrayList list1 = new ArrayList();
            for (int i = 0; i < 12345678; i++)
            {
                list1.Add(i);
            }
            Console.WriteLine("完成ArrayList");

            List<int> list2 = new List<int>();
            for (int i = 0; i < 12345678; i++)
            {
                list2.Add(i);
            }
            Console.WriteLine("完成List");
            #endregion

            int[] arr = { 1, 2, 3, 45, 5 };
            test(arr);
            testparams("hello", 1, 2, 3, 4, 5, 6, 7, 8);


            Person p = new Person { Name = "a", Inclass = new Person() };
            Person b = new Person { Name = "a", Inclass = new Person() };
            Person c = b.Clone() as Person;
            bool r = (c == b);//bject.Equals(c, b);
            Console.WriteLine("Object.Equals: {0}-{1}-{2}", c.Name, b.Name, r);
            bool s = c.Equals(b);
            Console.WriteLine("Equals: {0}-{1}-{2}", c.Name, b.Name, s);
            bool u = Object.ReferenceEquals(c, b);
            Console.WriteLine("Object.ReferenceEquals: {0}-{1}-{2}", c.Name, b.Name, u);

            //string aa = "abcdefg";
            //char[] cc =new char[aa.Length];
            //for (int i = 0; i < cc.Length; i++)
            //{
            //    cc[i]=(char)(aa[i]+1);
            //}
            //Console.WriteLine(cc);


            //Console.ReadKey();
        }
        static void test(int[] a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void testparams(string name, params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void testobj(Person p)
        {
            p.Name = "e";
        }
    }
}
