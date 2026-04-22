namespace Challenge_1
{
    internal class Program
    {

        //Tax Calculator: Write a method calculating net salary after tax.
        // Ex: Calc(1000, 0.1) => 900
        static void Main(string[] args)
        {
            double grossSalary = 1000;
            double taxRate = 0.1;
            double NetSalary=CalculateNetSalary(grossSalary,taxRate);
            Console.WriteLine($"Net salary: {NetSalary:C} \nGross Salary: {grossSalary:C} \nTax Rate: {taxRate:P} ");

        }

        public static double CalculateNetSalary(double grossSalary, double taxRate)
        {
            if (grossSalary<0 || taxRate<0 || taxRate>1)
            {
                throw new ArgumentException("Gross Salary must be positive and TaxRate between 0 and 1.");
            }
            double taxAmount = grossSalary * taxRate;
            return grossSalary - taxAmount;

        }
    }
}
