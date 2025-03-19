using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        static string PrintAverage(double[] temperatures)
        {
            double average = CalculateAverage(temperatures);
            return $"The average temperature is {average}";
        }

        static double CalculateAverage(double[] temperatures)
        {
            double sum = 0;
            foreach (double temp in temperatures)
            {
                sum += temp;
            }
            double average = sum / temperatures.Length;
            return average;
        }
        public static void Main(string[] args)
        {
            double[] temperatures = new double[] { 23.5 };

            Console.WriteLine(PrintAverage(temperatures));
        }
    }
}
