using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Compare : IComparable
    {
        int Lvalue;
        public Compare(int length)
        {
            Lvalue = length;
        }

        public int CompareTo(object obj)
        {
            if (Lvalue > ((Compare)obj).Lvalue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
