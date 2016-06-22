using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomLinkedList : ICustomString
    {
        LinkedList<char> myLinkedList = new LinkedList<char>();

        public CustomLinkedList()
        {

        }

        public void Insert(string stringToInsert)
        {
            char convertedstring = Convert.ToChar(stringToInsert);
            if (myLinkedList.Count == 0)
            {
                myLinkedList.AddFirst(convertedstring);
            }
            else
            {
                LinkedListNode<char> lastNode = myLinkedList.Last;
                myLinkedList.AddAfter(lastNode, convertedstring);
            }
        }

        public int Length()
        {
            int listcount = myLinkedList.Count;
            return listcount;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedList<char> tempList = new LinkedList<char>();
            LinkedListNode<char> nextnode = null;
            int count = 0;
            foreach (char item in myLinkedList)
            {
                if (count >= startIndex && numCharsToRemove > 0)
                {
                    count++;
                    numCharsToRemove--;
                }
                else
                {
                    if (tempList.Count == 0)
                    {
                        tempList.AddFirst(item);
                        nextnode = tempList.Last;
                    }
                    else
                    {
                        tempList.AddAfter(nextnode, item);
                        nextnode = tempList.Last;
                    }
                    count++;
                }
            }
            myLinkedList = tempList;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char node in myLinkedList)
            {
                if (sb.Length == 0)
                {
                    sb.Append(node);
                }
                else
                {
                    sb.Append(", " + node);
                }
            }
            return sb.ToString();
        }
    }
}
