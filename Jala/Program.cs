using System;

namespace Jala
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basic
            //Basics---------------------1
            int empID = 5;
            string empName = "Puja";
            Console.WriteLine("Employee Id :" + empID + " Name : " + empName);
            //functions
            basics ob = new basics();
            int number = 2;
            Console.WriteLine("{0} is :{1}", number, ob.oddOrEven(number));
            int a = 22;
            int b = 65;
            ob.swap(ref a, ref b);
            Console.WriteLine("Swap a and b :a={0} and b={1}", a, b);
            //Basics---------------------1
            #endregion
            #region Read And Write
            Read_and_Write obj = new Read_and_Write();
            obj.Stringcontacenate();
            int value1 = 5;
            int value2 = 4;
            Console.WriteLine("sum of {0} and {1} is {2}", value1, value2, obj.add(value2, value1));
            #endregion
        }
    }
}
