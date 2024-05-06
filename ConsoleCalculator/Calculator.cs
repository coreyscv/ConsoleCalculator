namespace ConsoleCalculator
{
    public class Calculator
    {
        public static int number1 { get; set; }
        public static int number2 { get; set; }
        public static bool loop = true;
        
        public static void RequestNumbers()
        {
            Console.WriteLine("Enter two numbers for calculation");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
        }
        public static int RequestInput()
        {
            Console.WriteLine();
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Multiplication");
            Console.WriteLine("4 Division");
            Console.WriteLine("5 Enter new numbers for calculation");
            Console.WriteLine("6 Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static void Calculation(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    break;
                case 5:
                    break;
                case 6:
                    loop = false;
                    break;
            }
        }
    }
}