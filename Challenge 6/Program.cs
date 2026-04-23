namespace Challenge_6
{
    internal class Program
    {
        //FizzBuzz app
        static void Main(string[] args)
        {
            Console.WriteLine("---FizzBuzz---");
            Console.Write("Please Enter Number of Iterations: ");

            int.TryParse(Console.ReadLine(),out int count);

            FizzBuzz(count);

        }

        public static int FizzBuzz(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 7 == 0)
                    Console.WriteLine("Lucky");
                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else
                    Console.WriteLine(i);
            }
            return count;
        }
    }
}
