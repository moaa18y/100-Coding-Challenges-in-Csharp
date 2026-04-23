namespace Challenge_7
{
    internal class Program
    {
        //String Inspector and Operations
        static void Main(string[] args)
        {
            string sentence = "     The Quick Brown Fox Jumps Over The Lazy Dog     ";
            string TrimmedSentence = StringTrim(sentence);
            string LowerCase = TrimmedSentence.ToLower();

            Console.WriteLine($"Trimmed Sentence: {TrimmedSentence}");
            Console.WriteLine($"Character Count: {CharCount(TrimmedSentence)}");
            Console.WriteLine($"Sentence in Lower case: {LowerCase}");
            Console.WriteLine($"Count of Letter o: {CharCountSpecific(TrimmedSentence, 'o', 'O')}");
            Console.WriteLine($"Space Replacment with '_': {ReplaceTwoLetters(TrimmedSentence,' ','_')}");
        }
        public static string StringTrim(string sentence) 
        {
            if (string.IsNullOrEmpty(sentence))
                throw new ArgumentNullException("Cannot be null");
            return sentence.Trim();
        }

        public static int CharCount(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return 0;
            return sentence.Count();
        }
            
        public static int CharCountSpecific(string sentence, char destCharLower, char destCharUpper)
        {
            if (string.IsNullOrEmpty(sentence))
                return 0;
            return sentence.Count(c => c == destCharLower || c == destCharUpper);
        }
        
        public static string ReplaceTwoLetters(string sentence, char firstLetter, char secondLetter)
        {
            if (string.IsNullOrEmpty(sentence))
                throw new ArgumentNullException();
            return sentence.Replace(firstLetter, secondLetter);
        }
    }
}
