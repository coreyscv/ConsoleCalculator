namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Calculator.loop)
            {
                Calculator.RequestNumbers();
                int userInput = Calculator.RequestInput();
                Calculator.Calculation(userInput);
            }
        }
    }
}