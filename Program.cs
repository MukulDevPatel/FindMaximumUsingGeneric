
namespace FindMaximumUsingGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            double firstNumber = 3.2;
            double secondNumber = 2.2;
            double thirdNumber = 1.2;

            double value=FindMaximum.MaximumDoubleValue(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(value);
        }
    }
}
