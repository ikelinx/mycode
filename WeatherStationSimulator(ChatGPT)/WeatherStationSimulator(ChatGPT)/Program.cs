using System;
using System.Linq;

namespace WeatherStationSimulator
{
    internal class Program
    {
        // Find the most common weather condition
        static string MostCommonCondition(string[] conditions)
        {
            return conditions.GroupBy(x => x)
                             .OrderByDescending(g => g.Count())
                             .First()
                             .Key;
        }

        // Calculate the average temperature
        static double AverageTemperature(int[] temperatures)
        {
            return temperatures.Average();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperatures = new int[days];
            string[] weatherConditions = new string[days];

            Random random = new Random();

            // Generate correlated temperature and weather condition
            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 40);

                if (temperatures[i] > 25)
                    weatherConditions[i] = "Sunny";
                else if (temperatures[i] > 10)
                    weatherConditions[i] = "Cloudy";
                else if (temperatures[i] > 0)
                    weatherConditions[i] = "Rainy";
                else
                    weatherConditions[i] = "Snowy";
            }

            // Display generated data
            Console.WriteLine("\n--- Weather Simulation Results ---");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: Temp: {temperatures[i]}°C, Weather: {weatherConditions[i]}");
            }

            Console.WriteLine($"\nAverage Temperature: {AverageTemperature(temperatures):F2}°C");
            Console.WriteLine($"Max Temperature: {temperatures.Max()}°C | Min Temperature: {temperatures.Min()}°C");
            Console.WriteLine($"Most Common Weather Condition: {MostCommonCondition(weatherConditions)}");
        }
    }
}
