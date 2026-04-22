namespace Challenge_4
{
    internal class Program
    {
        //Vowel Counter: Count (a, e, i, o, u) in a string.
        //Ex: "Hello" => 2
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            int vowelCount = CountVowels(input);
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }
        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }
    }
}
