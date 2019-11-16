using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
            Console.WriteLine("=");

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
