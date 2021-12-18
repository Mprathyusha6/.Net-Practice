using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class stringType
    {
        public void ReverseString(string stringInput)
        {
            // Reverse using While loop  
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

        }
        public void stringLength(string s)
        {
            int length = 0;
            foreach (char ch in s)
            {
                length++;
            }
            Console.WriteLine("string Length {0}", length);
        }
    }
}
