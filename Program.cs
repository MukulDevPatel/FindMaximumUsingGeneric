
namespace FindMaximumUsingGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            int firstNumber = 400;
            int secondNumber = 600;
            int thirdNumber = 100;

            int value=FindMaximum.MaximumIntegerValue(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(value);
        }
    }
}
