using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SortList
    {

        public void SortLists(CustomString cstring, CustomArray carray, CustomLinkedList cllist)
        {
            SortedList<Compare, string> sortlist = new SortedList<Compare, string>();
            Compare compare1 = new Compare(cstring.Length());
            Compare compare2 = new Compare(carray.Length());
            Compare compare3 = new Compare(cllist.Length());
            sortlist.Add(compare1, cstring.ToString());
            sortlist.Add(compare2, carray.ToString());
            sortlist.Add(compare3, cllist.ToString());
            foreach (var list in sortlist)
            {
                Console.WriteLine(list.Value);
            }
        }
    }
}
