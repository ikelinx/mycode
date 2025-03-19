// Simple Calculator made by Kyle Ma + ChatGPT 16/03/2025

//First Number
Console.WriteLine("Enter the first number:");
string userInput1 = Console.ReadLine();

int firstNumber = int.Parse(userInput1);
Console.WriteLine($"You have entered: {firstNumber}");

//Second Number
Console.WriteLine("Enter the second number:");
string userInput2 = Console.ReadLine();

int secondNumber = int.Parse(userInput2);
Console.WriteLine($"You have entered: {secondNumber}");

//Operation
Console.WriteLine("Please choose operation: +, -, *, /");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        int sumAddition = firstNumber + secondNumber;
        Console.WriteLine($"Calculation complete: {firstNumber} + {secondNumber} = {sumAddition}");
        break;
    case "-":
        int sumMinus = firstNumber - secondNumber;
        Console.WriteLine($"Calculation complete: {firstNumber} - {secondNumber} = {sumMinus}");
        break;
    case "*":
        int sumMultiply = firstNumber * secondNumber;
        Console.WriteLine($"Calculation complete: {firstNumber} * {secondNumber} = {sumMultiply}");
        break;
    case "/":
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            int sumDivide = firstNumber / secondNumber;
            Console.WriteLine($"Calculation complete: {firstNumber} / {secondNumber} = {sumDivide}");
        }
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        break;
}

Console.ReadKey();

