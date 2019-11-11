using System;

namespace StrategicPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator1 = new Calculator1();
            CalculatorContext context = new CalculatorContext(calculator1);
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            context.Display(numbers);

            ICalculator calculator2 = new Calculator2();

            context = new CalculatorContext(calculator2);
            context.Display(numbers);

            Console.ReadLine();
        }
    }
}
