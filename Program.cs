
namespace FindMaximumUsingGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            string firstName = "Max";
            string secondName = "Maximum";
            string thirdName = "StringValue";

            string value=FindMaximum.MaximumStringValue(firstName, secondName, thirdName);
            Console.WriteLine(value);
        }
    }
}
