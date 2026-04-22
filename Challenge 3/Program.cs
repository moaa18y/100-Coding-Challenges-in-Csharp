namespace Challenge_3
{
    internal class Program
    {
        //Even/Odd Checker: Check if a number is even or odd.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckEvenOdd(number);
        }

        public static void CheckEvenOdd(int number)
        {
            if(number < 0)
                throw new ArgumentException("Number must be non-negative.");
            else if (number % 2 ==0)
                Console.WriteLine($"Number: {number} is even");
            else
                Console.WriteLine($"Number: {number} is odd");
        }

    }
}
