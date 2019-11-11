using System;
using System.Collections.Generic;
using System.Text;

namespace StrategicPatternExample
{
    class CalculatorContext
    {
        private readonly ICalculator calculator;

        public CalculatorContext(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public void Display(int[] numbers)
        {
            double result = this.calculator.GetSum(numbers);
            Console.WriteLine($"Result is : {result}");
        }
    }
}
