using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class basics
    {
        public string oddOrEven(int n)
        {
            if (n % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "odd";
            }
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
