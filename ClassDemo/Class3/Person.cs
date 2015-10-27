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
            return base.MemberwiseClone();
        }
    }
}
