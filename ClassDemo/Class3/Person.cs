using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Person:ICloneable
    {
        string _naem;
        Person inclass;
        public string Name
        {
            get
            {
                return _naem;
            }

            set
            {
                _naem = value;
            }
        }

        internal Person Inclass
        {
            get
            {
                return inclass;
            }

            set
            {
                inclass = value;
            }
        }

        public object Clone()
        {
            Person temp = new Person();
            temp.Name = Name;
            temp.inclass = new Person { Name = this.Name };//deep clone
            temp.inclass = this.Name;//
            return temp;//base.MemberwiseClone();
        }
    }
}
