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
                        #region Built-in-Data-Types
                        Built_In_Data_Types obj1 = new Built_In_Data_Types();
                        obj1.boolValue();
                        obj1.doubleToDecimal();
                        obj1.ArthmeticOperation();
                        obj1.Reverse(5);
                        obj1.checkChar();
                        #endregion

                        #region String
                        stringType obj2 = new stringType();

                        obj2.ReverseString("hello");
                        obj2.stringLength("hello");
                        #endregion 
                        #region Operators
                        operators ob3 = new operators();
                        ob3.Binary_Arithmetic_Operators(5, 10);
                        ob3.Unary_Arithmetic_Operators();
                        ob3.Relational_Operators();
                        #endregion  
            #region Type conversion
            TypeConversions ob4 = new TypeConversions();
            ob4.implicit_convertions();
            ob4.Explicit_convertion();
            ob4.type_conversion();
            #endregion  
            #region if Statement
            IfStatement ob5 = new IfStatement();
            ob5.positiveOrNegative();
            ob5.Checkvowel('c');
            ob5.LeapyearOrNot(2005);

            #endregion 
            #region  for
            Forloop ob6 = new Forloop();
            ob6.sumOfNumbers(5);
            ob6.sumOfOddNumber(5);
            ob6.ForEachLoop();
            #endregion

        }
    }
}
