namespace workingWithStringsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            string reversedString = ReverseString(userInput);
            Console.WriteLine("Reversed string: " + reversedString);

            Console.WriteLine("Enter a search string:");
            string searchString = Console.ReadLine();
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine("Number of occurrences of " +searchString+ ":" + occurrences);

            Console.WriteLine("Enter the old substring to replace:");
            string oldSubstring = Console.ReadLine();

            Console.WriteLine("Enter the new substring:");
            string newSubstring = Console.ReadLine();

            string replacedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine("String after replacement: " + replacedString);

            string noWhitespaceString = RemoveWhitespace(userInput);
            Console.WriteLine("String without whitespace: " + noWhitespaceString);
        }
        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int startIndex = 0;

            while ((startIndex = inputString.IndexOf(searchString, startIndex)) != -1)
            {
                count++;
                startIndex += searchString.Length;
            }

            return count;
        }
        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }
        static string RemoveWhitespace(string inputString)
        {
            return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
        }
        }
    }

