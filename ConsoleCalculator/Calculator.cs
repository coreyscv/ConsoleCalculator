namespace ConsoleCalculator
{
    public class Calculator
    {
        public static int number1 { get; set; }
        public static int number2 { get; set; }
        public static bool loop { get; set; }
        
        public static void RequestNumbers()
        {
            Console.WriteLine("Enter two numbers for calculation");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            loop = true;
        }
        public static int RequestInput()
        {
            Console.WriteLine();
            Console.WriteLine("1 for addition");
            Console.WriteLine("2 for subtraction");
            Console.WriteLine("3 for multiplication");
            Console.WriteLine("4 for division");
            Console.WriteLine("5 for new numbers to calculate");
            Console.WriteLine("6 to exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
    }
}