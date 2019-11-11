using System;
using System.Collections.Generic;
using System.Text;

namespace StrategicPatternExample
{
    public class Calculator2 : ICalculator
    {
        public double GetSum(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i] + 10;
            }

            return sum;
        }
    }
}
