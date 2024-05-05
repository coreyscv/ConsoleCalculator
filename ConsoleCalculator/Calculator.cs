namespace ConsoleCalculator
{
    internal class Calculator
    {
        public static int a { get; set; }
        public static int b { get; set; }
        public static bool c { get; set; }

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

        public static void RequestCalc()
        {
            Console.WriteLine("Please list two numbers for the calculation, one at a time.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = true;
        }
    }
}