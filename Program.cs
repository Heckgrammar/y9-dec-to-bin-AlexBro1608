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
            ////STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            //int myInt = 0; //just for testing single stepping
            //string myString = "12"; //watch me being cast from string to int
            //int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
            //string myIntAsString = myInt.ToString();
            //myString = myString + myIntAsString;
            //MAIN:  NUMBER CONVERSION PROGRAM
            int usernum = 257;
            while (usernum <= -1 || usernum >= 256)
            {
                Console.WriteLine("Enter your number from 0 to 255: ");
                usernum = Convert.ToInt32(Console.ReadLine());
            }
            string[] BinaryNum = { "0", "0", "0", "0", "0", "0", "0", "0" };
            for (int i = 0; i < BinaryNum.Length; i++)
            {
                string result = numberConversion(usernum, 2);
                BinaryNum[7 - i] = result;
                usernum = usernum / 2;
            }
            Console.WriteLine(BinaryNum[0] + BinaryNum[1] + BinaryNum[2] + BinaryNum[3] + BinaryNum[4] + BinaryNum[5] + BinaryNum[6] + BinaryNum[7]);
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = Convert.ToString(number % numberbase);
            return result;
        }
    }
}
