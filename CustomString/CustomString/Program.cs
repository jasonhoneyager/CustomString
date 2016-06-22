using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString cstring = new CustomString();
            CustomArray carray = new CustomArray();
            CustomLinkedList cllist = new CustomLinkedList();

            cstring.Insert("hello");
            int length1 = cstring.Length();
            cstring.Remove(2, 3);
            int length12 = cstring.Length();
            string print1 = cstring.ToString();
            Console.WriteLine("{0}: {1}: {2}", length1, print1, length12);

            carray.Insert("1");
            carray.Insert("2");
            carray.Insert("3");
            carray.Insert("4");
            carray.Insert("5");
            int length2 = carray.Length();
            carray.Remove(1, 1);
            int length22 = carray.Length();
            string print2 = carray.ToString();
            Console.WriteLine("{0}: {1}: {2}", length2, print2, length22);

            cllist.Insert("A");
            cllist.Insert("B");
            cllist.Insert("C");
            cllist.Insert("D");
            cllist.Insert("E");
            int length3 = cllist.Length();
            cllist.Remove(3,2);
            int length32 = cllist.Length();
            string print3 = cllist.ToString();
            Console.WriteLine("{0}: {1}: {2}", length3, print3, length32);

            SortList sort = new SortList();
            sort.SortLists(cstring, carray, cllist);
            Console.ReadKey(true);
        }
    }
}
