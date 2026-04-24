namespace Challenge_8
{
    internal class Program
    {
        //Grade Calculator
        static void Main(string[] args)
        {
            const int numberOfScores = 5;
            int[] scores = new int[numberOfScores];

            for(int i = 0; i < numberOfScores;i++)
                scores[i] = ReadValidScore(i + 1);

            double average = CalculateAverage(scores);
            int highestScore = HighestScore(scores);
            int lowestScore = LowestScore(scores);
            string grade = GetGrade(average);
            PrintReport(scores,average,grade,highestScore,lowestScore);
        }

        public static int ReadValidScore(int scoreNumber)
        {
            while (true)
            {
                Console.WriteLine($"Enter Grade {scoreNumber}:");
                int score = int.TryParse(Console.ReadLine(), out int parsed) ? parsed : -1;
                if (score >= 0 && score <= 100)
                    return score;
                else
                    Console.WriteLine("Enter in range (0-100)");
            }
        }

        public static double CalculateAverage(int[] scores) => scores.Average();

        public static int HighestScore(int[] scores) => scores.Max();
        public static int LowestScore(int[] scores) => scores.Min();

        public static string GetGrade(double average)
        {
            return average switch
            {
                >= 90 and <= 100 => "A (Excellent)",
                >= 80 and <= 89 => "B (Good)",
                >= 70 and <= 79 => "C (Above Average)",
                >= 60 and <= 69 => "D (Pass)",
                _ => "F (Fail)"
            };          
        }

        public static void PrintReport(int[]scores, double average, string grade, int highestScore, int lowestScore)
        {
            Console.WriteLine($"Scores: {string.Join(", ",scores)}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Highest: {highestScore} | Lowest: {lowestScore}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Status: {(average>=60 ? "Pass":"Fail")}");
        }

    }

}
