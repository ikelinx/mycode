namespace WeatherStationSimulator
{
    internal class Program
    {
        // Find the most common weather condition
        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }

        // Calculate the average temperature
        static double AverageTemperature(double[] temperatures)
        {
            double sum = 0;
            foreach (double temp in temperatures)
            {
                sum += temp;
            }
            double average = sum / temperatures.Length;
            return average;
        }

        public void PrintAverageTemperature(double[] temperatures)
        {
            double average = AverageTemperature(temperatures);
            Console.WriteLine($"The average temperature is: {average}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double days))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Create arrays to store temperature and weather condition for each day
            int daysInt = (int)days;
            double[] temperature = new double[daysInt];

            string[] conditionsList = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherCondition = new string[daysInt];

            // Create a random number generator
            Random random = new Random();

            // Generate random temperature and weather condition for each day
            for (int i = 0; i < daysInt; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherCondition[i] = conditionsList[random.Next(conditionsList.Length)];
            }

            for (int i = 0; i < daysInt; i++)
            {
                Console.WriteLine($"Day {i + 1}: Temp: {temperature[i]}C, Weather: {weatherCondition[i]}");
            }

            Program program = new Program();
            program.PrintAverageTemperature(temperature);
            Console.WriteLine($"Max Temperature is {temperature.Max()} and Min Temperature is: {temperature.Min()}");
            Console.WriteLine($"The most common condition is: {MostCommonCondition(weatherCondition)}");
        }
    }
}
