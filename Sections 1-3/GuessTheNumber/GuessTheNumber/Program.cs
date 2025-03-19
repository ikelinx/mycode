//Generate a random number between 1-100

Random rand = new Random();
int secretNumber = rand.Next(1, 101);
int userGuess = 0;
int attemptsNo = 0;

Console.WriteLine("Welcome to the Guess the Number Game!");
Console.WriteLine("I am thinking of a number between 1 and 100. Can you guess it?\n");

while (userGuess != secretNumber)
{
    attemptsNo++;
    Console.WriteLine("Enter your guess:");
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low, try again!");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high, try again!");
    }
    else
    {
        Console.WriteLine($"You guessed it!, it took you {attemptsNo} attempts.");
    }
}