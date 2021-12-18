using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class Forloop
    {
        public void sumOfNumbers(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "\n");
                sum = sum + i;
            }
            Console.WriteLine("Sum {0}", sum);
        }
        public void sumOfOddNumber(int n)
        {
            int sum = 0;
            int temp=1;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + temp;
                Console.WriteLine(temp + "\n");
                temp = temp+2;

            }
            Console.WriteLine("sum {0}", sum);
        }
        public void ForEachLoop()
        {
            char[] charArray= { 'j','a','l','a','T','e','c','h','n','o','l','o','g','i','e','s' };
            Console.WriteLine("Using for loop");
            for(int i=0;i<charArray.Length;i++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine("\n using ForEach");
            foreach(char c in charArray)
            {
                Console.Write(c);
            }
        }

    }
}
