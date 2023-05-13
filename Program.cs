﻿
using System.Collections;

namespace FindMaximumUsingGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            int firstNumber = 80;
            int secondNumber = 100;
            int thirdNumber = 110;

            double fourNumber = 80.2;
            double fifthNumber = 80.56;
            double sixthNumber = 80.60;

            string firstName = "Max";
            string secondName = "Maximum";
            string thirdName = "StringValue";

            string value = GenericMaximum<string>.MaximumValue(firstName, secondName, thirdName);
            Console.WriteLine(value);

            int Numvalue = GenericMaximum<int>.MaximumValue(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(Numvalue);
            
            double Doublevalue = GenericMaximum<double>.MaximumValue(fourNumber, fifthNumber, sixthNumber);
            Console.WriteLine(Doublevalue);
        }
    }
}
