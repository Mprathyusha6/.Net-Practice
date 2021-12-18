using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class operators
    {
        public void Binary_Arithmetic_Operators(int x,int y)
        {
            Console.WriteLine("Addition Operator {0}", x + y);
            Console.WriteLine("Subtraction Operator {0}",x-y);
            Console.WriteLine("Multiplication  Operator {0}",x*y);
            Console.WriteLine("Division  Operator {0}",x/y);
            Console.WriteLine("Modulo  Operator {0}",x%y);
        }

        public void Unary_Arithmetic_Operators()
        {
            int x = 10;
            int y = 10;
            int z = 10;
            int s = 10;
            Console.WriteLine("preincrement for 10 = {0}", ++x);
            Console.WriteLine("postincrement for 10 = {0}", y++);
            //Console.WriteLine(" {0}", y++);
            Console.WriteLine("predecrement for 10 = {0}", --z);
            Console.WriteLine("postdecrement for 10 = {0}", s--);

        }

        public void Relational_Operators()
        {
            Console.WriteLine("Equal to Operator : {0}",11==12);
            Console.WriteLine("Greater than  to Operator : {0}", 11 > 12);
            Console.WriteLine("Less than  to Operator : {0}", 11 < 12);
            Console.WriteLine("Greater than or Equal to Operator : {0}", 11 >= 12);
            Console.WriteLine("Lesser than or Equal to Operator : {0}", 11 <= 12);
            Console.WriteLine(" Not Equal to Operator : {0}", 11 != 12);
        }
    }
}
