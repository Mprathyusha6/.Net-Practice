using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class Built_In_Data_Types
    {
        public void boolValue()
        {
            bool x = false; // variable initialization.  
            if (x == true) // conditional statements  
            {
                Console.WriteLine("The value of x is true");
            }
            else
                Console.WriteLine("The value of x is FALSE");
        }
        public void doubleToDecimal()
        {
            double a = 1.0;
            decimal b = 2.1m;
            Console.WriteLine(a + (double)b);
            Console.WriteLine((decimal)a + b);
        }
        public void ArthmeticOperation()
        {
            int x =Convert.ToInt32( Console.ReadLine());
            int y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X + Y ={0}", x + y);
            Console.WriteLine("X - Y ={0}", x - y);
            Console.WriteLine("X * Y ={0}", x * y);
            if(y!=0)
            Console.WriteLine("X/Y ={0}", x / y);
        }
        public void Reverse(int n)
        {
            char[] charecters=new char[n];
            char[] reverse=new char[n];
            int j = 0;
            for(int i=0;i<n;i++)
            {
                charecters[i] =Convert.ToChar( Console.ReadLine());
            }
            for(int i=n-1;i>=0;i--)
            {
                reverse[j] = charecters[i];
                j++;
            }
            Console.WriteLine(reverse);
        }
        public void checkChar()
        {
            char ch = Convert.ToChar(Console.ReadLine());

            
            int v = ch;
            if(v>=97 && v<=122)
            {
                if(ch=='a'|| ch=='e' || ch=='i'|| ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("It is a lowercase vowel");
                }
                else
                {
                    Console.WriteLine("It is a lowercase letter");

                }
            }
            else if (v >= 48 && v <= 57)
            {
                Console.WriteLine("It is a digit");
            }
            else
            {
                Console.WriteLine("It is a symbol");
            }
               

        }
    }
}
