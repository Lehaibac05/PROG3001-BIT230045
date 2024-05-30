namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of elements in the array: ");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            int maxValue = numbers.Max();
            Console.WriteLine("The maximum value in the array is: " +maxValue);
        }
    }
}
