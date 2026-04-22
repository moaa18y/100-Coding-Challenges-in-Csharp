namespace Challenge_5
{
    internal class Program
    {
        //String Reverser: Reverse a given string without using built-in reverse methods.
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input); 
            Console.WriteLine($"Reversed string: {reversed}");
        }
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Cannot be null.");
            char[] reversedChar = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
                reversedChar[i] = input[input.Length - 1 - i];
            return new string(reversedChar);
        }
    }
}
