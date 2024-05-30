namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();
            int integerNumber;
            bool success = int.TryParse(input, out integerNumber);

            if (success)
            {
                double doubleNumber = (double)integerNumber;
                Console.WriteLine("The number you entered is: " + integerNumber + "and as a double is: " + doubleNumber");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
