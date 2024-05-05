namespace ConsoleCalculator
{
    public class Calculator
    {
        public static int num1 { get; set; }
        public static int num2 { get; set; }
        public static bool loop { get; set; }
        
        public static void RequestNum()
        {
            Console.WriteLine("Enter two numbers for calculation");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
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

        public static void Calculation()
        {
            while (loop)
            {
                int userInput = RequestInput();

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    case 5:
                        Console.WriteLine();
                        RequestNum();
                        break;
                    case 6:
                        loop = false;
                        break;
                }
            }
        }
    }
}