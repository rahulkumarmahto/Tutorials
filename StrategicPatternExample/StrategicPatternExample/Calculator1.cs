using System;
using System.Collections.Generic;
using System.Text;

namespace StrategicPatternExample
{
    public class Calculator1 : ICalculator
    {
        public double GetSum(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
