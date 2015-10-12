﻿using System;
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
            #region 类型转换，值类型
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
            Console.WriteLine("{0}--{1}--{2}--{3}--{4}--{5}--{6}", a, b, c, d, e, f, g);
            #endregion

            #region string初步
            char ch = '你';
            string message1 = "hello";
            message1 += ", world";
            string message2 = message1 + "!";
            Console.WriteLine("message's length is {0}", message1.Length);
            //索引器
            ch = message1[2];
            //转义字符
            string filepath1 = "C:\\WIndows\\System32\\drivers\\etc\\hosts";
            Console.WriteLine(filepath1);
            //@原意
            string filepath2 = @"C:\Windows\System32\drivers\etc\hosts";
            Console.WriteLine(filepath2);

            #endregion

            #region string 引用
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is " + s1);
            Console.WriteLine("s2 is " + s2);

            s1 = "another string";
            Console.WriteLine("s1 is " + s1);
            Console.WriteLine("s2 is " + s2);
            #endregion

            #region 真正的引用
            Person p1 = new Person { age = 20 };
            Person p2 = p1;
            p1.tellage();
            p2.tellage();
            //改变原始值
            p1.age = 30;
            p1.tellage();
            p2.tellage();
            #endregion

            #region 数组
            int[] inter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] inter2 = inter;
            inter2[0] = 10086;
            Console.WriteLine("the first element of inter " + inter[0]);
          
            int[] myarray = new int[4];
            int[] myarray2 = new int[4] { 1, 2, 3, 4 };
            int[] myarray3 = new int[] { 1, 2, 3, 4 };
            foreach (var item in inter)
            {
                Console.WriteLine(item);

            }
            double  av=inter.Average();
            

            Person[] persons = new Person[5];
            persons[0] = new Person { age = 23, Name = "Peter" };
            persons[1] = new Person { age = 25, Name = "Mike" };
            persons[2] = new Person { age = 26, Name = "Alpha" };
            persons[3] = new Person { age = 27, Name = "Beta" };
            persons[4] = new Person { age = 28, Name = "Zara" };
            Person[] persons2 =
            {
                new Person {age=27,Name="Frank" },
                new Person {age=21,Name="Blank" }
            };

            int[,] twodim =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            twodim[0, 0] = 1;
            twodim[0, 1] = 1;
            twodim[0, 2] = 1;

            //锯齿
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 3, 4 };
            jagged[1] = new int[5] { 3, 4, 5, 67, 7 };
            jagged[2] = new int[3] { 3, 5, 4 };
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int element = 0; element < jagged[row].Length; element++)
                {
                    Console.WriteLine("row {0},element:{1} ,value {2}", row, element, jagged[row][element]);
                }
            }
            #endregion
            Console.ReadLine();

        }
    }
}
