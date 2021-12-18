using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class IfStatement
    {
        public void positiveOrNegative()
        {
            int n = -4;
            if (n < 0)
            {
                Console.WriteLine("{0} Negative Value", n);
            }
            else
            {
                Console.WriteLine("{0} Positive value", n);
            }
        }
        public void LeapyearOrNot(int year)
        {
            if(year%400==0 || (year%4==0 && year % 100 == 0))
            {
                Console.WriteLine("{0}  Leap Year",year);

            }
            else
            {
                Console.WriteLine("{0} Not a Leap year", year);
            }
        }
        public void Checkvowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("{0} it is a vowel", c);
            }
            else
            {
                Console.WriteLine("{0} it is not a vowel", c);
            }
        }
    }
}
