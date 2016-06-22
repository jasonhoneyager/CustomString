using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomArray : ICustomString
    {
        char?[] myArray = new char?[1];

        public CustomArray()
        {
            myArray[0] = null;
        }

        public void Insert(string stringToInsert)
        {
            char convertedstring = Convert.ToChar(stringToInsert);
            if (myArray.Length == 1 && myArray[0] == null)
            {
                myArray[0] = convertedstring;
            }
            else
            {
                char?[] nextArray = new char?[myArray.Length + 1];
                myArray.CopyTo(nextArray, 0);
                nextArray[myArray.Length] = convertedstring;
                myArray = nextArray;
            }
        }

        public int Length()
        {
            int arraylength = myArray.Length;
            return arraylength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int newindex = myArray.Length - numCharsToRemove;
            char?[] tempArray = new char?[newindex];
            int count = 0;
            int index = 0;
            foreach (char item in myArray)
            {
                if (count >= startIndex && numCharsToRemove > 0)
                {
                    count++;
                    numCharsToRemove--;
                }
                else
                {
                    tempArray[index] = item;
                    index++;
                    count++;
                }
            }
            myArray = tempArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in myArray)
            {
                if (sb.Length == 0)
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append(", " + item);
                }
            }
            return sb.ToString();
        }
    }
}
