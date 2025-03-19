int sum = 0;
int counter = 0;
int currentScore;

do
{
    Console.WriteLine("Enter your student's score. Enter -1 to finish:");

    string input = Console.ReadLine();

    // ✅ Handle non-numeric input
    if (!int.TryParse(input, out currentScore))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
        continue; // Skip this loop iteration and ask again
    }

    if (currentScore != -1)
    {
        sum += currentScore; // ✅ Cleaner way to add
        counter++;
    }

} while (currentScore != -1);

// ✅ Prevent division by zero
if (counter > 0)
{
    double average = (double)sum / counter; // ✅ Use double for precise division
    Console.WriteLine($"The average score is: {Math.Round(average, 2)}");
}
else
{
    Console.WriteLine("No valid scores entered. Cannot calculate an average.");
}

Console.WriteLine("Thank you for using the score calculator!");
Console.ReadKey();
