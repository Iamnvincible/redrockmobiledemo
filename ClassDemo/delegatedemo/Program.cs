using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace delegatedemo
{
    class Program
    {
        delegate double process(double pram1, double pram2);
        static int counter = 0;

        static string displayString =
           "This string will appear one letter at a time. ";
        static void Main(string[] args)
        {
            //char a = Convert.ToChar(Console.ReadKey());
            //if (a == 'a')
            //{
            //    process p = add;

            //    double result = p(1.234, 2.234);
            //}
            //else
            //{
            //    process p = new process(muti);
            //    double result2 = p(1.234, 2.23
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += WriteChar;
            // myTimer.Elapsed += WriteChar2;
            //myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            //  myTimer.Elapsed += (sender, eventArgs) =>
            // {
            //     Console.Write(displayString[counter++ % displayString.Length]);
            //  };
            myTimer.Start();
            System.Threading.Thread.Sleep(2000);
            Console.ReadKey(); 
            //}

        }
        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }
        static double add(double p1, double p2)
        {
            return p1 + p1;
        }
        static double muti(double p1, double p2)
        {
            return p1 * p1;
        }
    }
}
