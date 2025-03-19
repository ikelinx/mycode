int AddTwoValues(int value1, int value2) 
{
    int result = value1 + value2;
    return result;
}

Console.WriteLine("Please enter first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter second number");
int num2 = int.Parse(Console.ReadLine());

int myResult = AddTwoValues(num1, num2);

Console.WriteLine("My Result is: " + myResult);