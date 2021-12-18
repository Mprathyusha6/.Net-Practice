using System;
using System.Collections.Generic;
using System.Text;

namespace Jala
{
    class TypeConversions
    {
        public void implicit_convertions()
        {
            Console.WriteLine("Enter int value");
            int n = Convert.ToInt32(Console.ReadLine());
            long y = n;
            Console.WriteLine("implicit conversion of int to Long {0}",y);
        }
        public void Explicit_convertion()
        {
            Console.WriteLine("Enter int Value");
            int n = Convert.ToInt32(Console.ReadLine());
            string s = n.ToString();
            Console.WriteLine("Value {0}", s);
        }
        public void type_conversion()
        { Console.WriteLine("Enter String");
            string s = Console.ReadLine();
            Console.WriteLine("Enter integer");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("string to float conversion {0}",float.Parse(s));
            Console.WriteLine("convert int to double {0}", Convert.ToDouble(n));


            Console.WriteLine("Enter int value");
            int invalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Float value");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("int.tostring : {0}",invalue.ToString());
            Console.WriteLine("float.tostring : {0}", f.ToString());
        }
    }
}
