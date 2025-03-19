class Program // Method Parameter Modifiers
{
    // ref keyword is used to pass the argument by reference. It means any changes made to the parameter will be reflected in the calling method.
    void AddValue(ref int number) // ref keyword is used in the method signature
    {
        number += 10; // Modify the original value
    }

    // out keyword is used to pass the argument by reference. It means the argument must be assigned before the method exits.
    void GetValue(out int result) // out keyword is used in the method signature
    {
        result = 42; // Single assignment is required
    }

    // Method with multiple in and out parameters
    void PlusAndMultiply(int x, int y, out int sum, out int product)
    {
        sum = x + y; // Assign the sum
        product = x * y; // Assign the product
    }

    // in keyword is used to pass the argument by reference but the parameter is read-only.
    void PrintValue(in int number) // in keyword is used in the method signature
    {
        Console.WriteLine("PrintValue Method: " + number); // Read-only access
    }

    // params keyword allows a method to accept a variable number of arguments.
    void PrintNumbers(params int[] numbers) // params keyword is used in the method signature
    {
        foreach (var number in numbers)
        {
            Console.WriteLine("PrintNumbers Method: " + number); // Print each number
        }
    }

    // Method to calculate the square of a number
    int Square(int number)
    {
        return number * number;
    }

    // Method to check if a number is even
    bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method to concatenate two strings
    string Concatenate(string str1, string str2)
    {
        return str1 + str2;
    }

    static void Main(string[] args) // Main method
    {
        Program p = new Program();

        int myNumber = 5;
        p.AddValue(ref myNumber); // ref keyword is used at the calling place
        Console.WriteLine("AddValue Method: " + myNumber); // Output: 15

        int myValue;
        p.GetValue(out myValue); // out keyword is used at the calling place
        Console.WriteLine("myValue Method: " + myValue); // Output: 42

        int a = 5, b = 3, sum, product;
        p.PlusAndMultiply(a, b, out sum, out product);
        Console.WriteLine($"PlusAndMultiply Method: Sum is {sum} and Product is {product}"); // Output: Sum: 8, Product: 15

        p.PrintValue(in myNumber); // in keyword is used at the calling place

        p.PrintNumbers(1, 2, 3, 4, 5); // params keyword is used at the calling place

        // Calling new methods
        int square = p.Square(4);
        Console.WriteLine("Square Method: " + square); // Output: 16

        bool isEven = p.IsEven(4);
        Console.WriteLine("IsEven Method: " + isEven); // Output: True

        string concatenatedString = p.Concatenate("Hello, ", "World!");
        Console.WriteLine("Concatenate Method: " + concatenatedString); // Output: Hello, World!
    }
}
