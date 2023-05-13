
namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'B', 'C', 'd' };

            //WhithoutGeneric.toPrint(intArray);
            //WhithoutGeneric.toPrint(doubleArray);
            //WhithoutGeneric.toPrint(charArray);

            //WithGeneric withGeneric = new WithGeneric();
            //withGeneric.toPrint<int,double,char>(intArray,doubleArray,charArray);

            //WithGeneric.toPrint<int>(intArray);
            //WithGeneric.toPrint<double>(doubleArray);
            //WithGeneric.toPrint<char>(charArray);

            //PrintArray<int> inputintArray = new PrintArray<int>(intArray);
            //inputintArray.toPrint();

            //PrintArray<double> inputdoubleArray = new PrintArray<double>(doubleArray);
            //inputdoubleArray.toPrint();

            //PrintArray<char> inputcharArray = new PrintArray<char>(charArray);
            //inputcharArray.toPrint();

            int firstNumber = 80;
            int secondNumber = 100;
            int thirdNumber = 110;

            double fourNumber = 80.2;
            double fifthNumber = 80.56;
            double sixthNumber = 80.60;

            string firstName = "Mukul";
            string secondName = "mukuldev";
            string lastName = "mukuldevpatel";

            //string val = FindMaxValue.MaximumStringValue(firstName, secondName, lastName);
            //Console.WriteLine(val);

            int val = FindMaximum<int>.MaximumIntNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(val);

            double doubleVal = FindMaximum<double>.MaximumIntNumber(fourNumber, fifthNumber, sixthNumber);
            Console.WriteLine(doubleVal);

            string stringVal = FindMaximum<string>.MaximumIntNumber(firstName, secondName, lastName);
            Console.WriteLine(stringVal);
        }
    }
}
