using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3Workout
{
    public class NameSort : IComparer<Student>
    {
        //public int Compare(Student x, Student y)
        //{
        //    return x.Name.CompareTo(y.Name);
        //}
        public int Compare(Student x, Student y)
        {
            return x.Number - y.Number;
        }
    }
}
