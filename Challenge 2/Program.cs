namespace Challenge_2
{
    internal class Program
    {
        //Temperature Converter: Convert Celsius to Fahrenheit and vice versa.
        //Ex: 0°C => 32°F.
        static void Main(string[] args)
        {
        double celsius = 25;
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }


        public static double CelsiusToFahrenheit(double celsius) => ((celsius * 9 / 5) + 32);

        public static double FahrenheitToCelsius(double fahrenheit) => ((fahrenheit - 32) * 5 / 9);
    }
}
