using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomString : ICustomString
    {
        string myString;

        public CustomString()
        {
            myString = "";
        }

        public void Insert(string stringToInsert)
        {
            myString = stringToInsert;
        }

        public int Length()
        {
            int stringlength = myString.Length;
            return stringlength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] temp = myString.ToCharArray();
            string newstring = null;
            int count = 0;
            foreach (char character in temp)
            {
                if (count >= startIndex && numCharsToRemove != 0)
                {
                    count++;
                    numCharsToRemove--;
                }
                else
                {
                    newstring = newstring + character;
                    count++;
                }
            }
            myString = newstring;

        }

        public override string ToString()
        {
            return myString;
        }
    }
}
