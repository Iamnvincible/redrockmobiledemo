using demo.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello line");
            Console.Write("hello write");
            Console.Write("hello write===================");
            Console.WriteLine("hello line11111111111111111111111");
            Person p = new Person();
            p.Name = "zhangsan";

            Student s = new Student();
            s.Name = "lisi";
            Class1 c = new Class1();
            p.Hi();
            p.Hi(334);
            int pr=p.Hello();
            int st = s.Hello();
            Console.WriteLine("父类的hello方法返回值是" + pr);
            Console.WriteLine("子类的hello方法返回值是" +st);

            Console.ReadLine();
        }
    }
}
