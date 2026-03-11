namespace Conditionals_Don_t_Feel_Very_Cold_To_Me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isNegative = number < 0;
            bool isOdd = number % 2 != 0;
            Console.WriteLine($"Is the number negative? {isNegative}");
            Console.WriteLine($"Is the number odd? {isOdd}");

            Console.WriteLine("The largest of - 7, 15, and 3 is: " + Math.Max(-7, Math.Max(15, 3)));

            Console.WriteLine("Enter a grade (A, B, C, D, E, F)");
            {   char grade = Convert.ToChar(Console.ReadLine().ToUpper());
                string result = grade switch
                {
                    'A' => "Excellent",
                    'B' => "Good",
                    'C' => "Average",
                    'D' => "Below Average",
                    'E' => "Poor",
                    'F' => "Failing",
                    _ => "Invalid grade"
                };
                Console.WriteLine(result);
            }

        }
    }
}
