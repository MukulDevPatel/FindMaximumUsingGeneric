using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGeneric
{
    public class GenericMaximum<T> where T : IComparable
    {
        public static T testMaximum(T first, T second)
        {
            if (first.CompareTo(second) > 0) 
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
