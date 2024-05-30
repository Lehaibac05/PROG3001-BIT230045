namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a character: ");
            string input = Console.ReadLine();
            if (input.Length == 1)
            {
                char character = input[0];
                int asciiCode = (int)character;
                Console.WriteLine("The character you entered is: " + character + ", its ASCII code is: " +asciiCode);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
            }
        }
    }
}
