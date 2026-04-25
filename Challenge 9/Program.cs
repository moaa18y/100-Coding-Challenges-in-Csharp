namespace Challenge_9
{
    internal class Program
    {
        //Number Analyzer
        //Read one integer from the user and print a full analysis.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to analysis: ");
            int.TryParse(Console.ReadLine(), out int parsed);

            Console.WriteLine($"Number Status: {NumberStatus(parsed)}");
            Console.WriteLine($"Even/Odd: {EvenOdd(parsed)}");
            Console.WriteLine($"IS Prime? {PrimeNumber(parsed)}");
            Console.WriteLine($"IS Perfect Square? {PerfectSquareNumber(parsed)}");
            Console.WriteLine($"Sum of Digits: {SumDigits(parsed)}");
            Console.WriteLine($"Reversed Digits: {ReversedDigits(parsed)}");

        }

        static string NumberStatus(int number)
        {
            if (number < 0)
                return "Negative";
            else if (number > 0)
                return "Positive";
            else
                return "Zero";
        }

        static string EvenOdd(int number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot be negative");
            else if (number % 2 == 0)
                return"Number is Even";
            else
                return"Number is Odd";
        }

        static bool PrimeNumber(int number)
        {
            bool isPrime = true;
            if (number <= 1)
                isPrime = false;
            for(int i=2; i * i <= number; i++)
            {
                if (number % i == 0)
                {                    
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static bool PerfectSquareNumber(int number)
        {
            bool isPerfect = false;
           
            if (number >= 0)
            {
                for (int i = 0; i * i <= number; i++)
                {
                    if (i * i == number)
                    {
                        isPerfect = true;
                        break;
                    }
                }
            }
            return isPerfect;
        }
        
        static int SumDigits(int  number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        

        static int ReversedDigits(int number)
        {

            int reversed = 0;

            while (number != 0)
            {
                
                reversed = (reversed * 10) + number % 10;
                number /= 10;
            }
            return reversed;

        }
    
    }
}
