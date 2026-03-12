namespace Conditionals_Don_t_Feel_Very_Cold_To_Me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user for whole number and assigns it to an integer variable
            Console.WriteLine("Enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Checks if the number is negative or positive
            if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is not negative.");
            }
            //Checks if the number is odd or even
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            // Creates two more integer variables and assigns them whole numbers
            int num1 = 34;
            int num2 = 42;
            // Gets first max
            int firstMax = Math.Max(number, num1);
            // Gets maximum number
            int max = Math.Max(firstMax, num2);
            //Prints max to the console
            Console.WriteLine($"The maximum of {number}, {num1}, and {num2} is: {max}");
            // Asks user for a grade and assigns it to a char variable
            Console.WriteLine("Enter a grade");
            char grade = Console.ReadKey().KeyChar;
            // Uses a switch statement to print a message based on the grade
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nExcellent!");
                    break;
                case 'B':
                    Console.WriteLine("\nGood job!");
                    break;
                case 'C':
                    Console.WriteLine("\nYou passed.");
                    break;
                case 'D':
                    Console.WriteLine("\nYou should try harder.");
                    break;
                case 'F':
                    Console.WriteLine("\nBetter luck next time.");
                    break;
                default:
                    Console.WriteLine("\nInvalid grade entered.");
                    break;

            }
        }
    }
}
