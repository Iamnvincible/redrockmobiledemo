using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Person
    {
        public int age { get; set; }

        public  string Name
        {
            get
            {
                return name +"is shabi";
            }

            set
            {
                name = value;
            }
        }

        private string name
            ;
        public void tellage()
        {
            Console.WriteLine("my age is " + age);
        }
    }
}
