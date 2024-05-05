namespace ConsoleCalculator
{
    class Program : Calculator
    {
        static void Main(string[] args)
        {
            RequestCalc();

            while (c)
            {
                int userInput = RequestInput();

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} x {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    case 5:
                        Console.WriteLine();
                        RequestCalc();
                        break;
                    case 6:
                        c = false;
                        break;
                }
            }
        }
    }
}