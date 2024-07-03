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
            int usernum = 65536;
            while (usernum <= -1 || usernum >= 65536)
            {
                Console.WriteLine("Enter your number from 0 to 65535: ");
                usernum = Convert.ToInt32(Console.ReadLine());
            }
            int userbase = 0;
            while (userbase <= 0 || userbase >= 17)
            {
                Console.WriteLine("Enter a number base between 1 and 16 that you want it converted into: ");
                userbase = Convert.ToInt32(Console.ReadLine());
            }
            if (userbase >= 1 & userbase <= 10)
            {
                string[] BinaryNum = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                for (int i = 0; i < BinaryNum.Length; i++)
                {
                    string result = numberConversion(usernum, userbase);
                    BinaryNum[15 - i] = result;
                    usernum = usernum / userbase;
                }
                Console.WriteLine(BinaryNum[0] + BinaryNum[1] + BinaryNum[2] + BinaryNum[3] + BinaryNum[4] + BinaryNum[5] + BinaryNum[6] + BinaryNum[7] + BinaryNum[8] + BinaryNum[9] + BinaryNum[10] + BinaryNum[11] + BinaryNum[12] + BinaryNum[13] + BinaryNum[14] + BinaryNum[15]);
            }
            else if (userbase >= 11 & userbase <= 16)
            {
                string[] BinaryNum = { "0", "0", "0", "0"};
                for (int i = 0; i < BinaryNum.Length; i++)
                {
                    string result = ToBase16Conversion(usernum, userbase);
                    BinaryNum[3 - i] = result;
                    usernum = usernum / userbase;
                }
                Console.WriteLine(BinaryNum[0] + BinaryNum[1] + BinaryNum[2] + BinaryNum[3]);
            }
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = Convert.ToString(number % numberbase);
            return result;
        }
        static string ToBase16Conversion(int number, int numberbase)
        {
            string result = Convert.ToString(number % numberbase);
            if (result == "10")
            {
                result = "A";
            }
            else if (result == "11")
            {
                result = "B";
            }
            else if (result == "12")
            {
                result = "C";
            }
            else if (result == "13")
            {
                result = "D";
            }
            else if (result == "14")
            {
                result = "E";
            }
            else if (result == "15")
            {
                result = "F";
            }
            return result;
        }
    }
}
