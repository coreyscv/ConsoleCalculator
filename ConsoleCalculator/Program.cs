namespace ConsoleCalculator
{
    class Program : Calculator
    {
        static void Main(string[] args)
        {
            RequestNumbers();
            Calculation();
        }

        public static void Calculation()
        {
            while (loop)
            {
                int userInput = RequestInput();

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
                        Console.WriteLine();
                        RequestNumbers();
                        break;
                    case 6:
                        loop = false;
                        break;
                }
            }
        }
    }
}