using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Person:Animal
    {
      private  string name;

        public string Name
        {
            get
            {
                return name+"is sb";
            }

            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 打招呼
        /// </summary>
        public void Hi()
        {
            Console.WriteLine(Name);
        }
        /// <summary>
        /// Hi的重载方法
        /// </summary>
        /// <param name="i">不知道</param>
        public void Hi(int i)
        {
            Console.WriteLine(name + "重载方法"+i);
        }
        public virtual int Hello()
        {
            return 0;
        }
    }
}
