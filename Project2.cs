namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a real number: ");
            string input = Console.ReadLine();
            double realNumber;
            bool success = double.TryParse(input, out realNumber);

            if (success)
            {
                int intNumber = (int)realNumber;
                long longNumber = (long)realNumber;

                Console.WriteLine("The number you entered is: " +realNumber +", as an int is: " +intNumber + "and as a long is: " + longNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid real number.");
            }
        }
    }
}

