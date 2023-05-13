
using System.Collections;

namespace FindMaximumUsingGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMax();

            GenericMaximum<double> generics = new GenericMaximum<double>(doubleArray);
            generics.PrintMax();

            GenericMaximum<char> genericMax = new GenericMaximum<char>(charArray);
            genericMax.PrintMax();
        }
    }
}
