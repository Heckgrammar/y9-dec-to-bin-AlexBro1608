using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
            string myIntAsString = myInt.ToString();
            myString = myString + myIntAsString;
            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine("Enter your number: ");
            int usernum = Convert.ToInt32(Console.ReadLine());
            string[] BinaryNum = { "0", "0", "0", "0", "0", "0", "0", "0" };
            for (int i = 0; i < BinaryNum.Length; i++)
            {
                numberConversion(usernum, 2);
                BinaryNum[7 - i] = result;
                usernum = usernum / 2;
            }
            //CODE GOES HERE
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            string result = Convert.ToString(number % numberbase);
            return result; //REMOVE THE RED LINE!
        }
    }
}
