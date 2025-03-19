// Parse() and TryParse() methods are used to convert a string to a number.
// Parse() method throws an exception if the conversion fails, while TryParse() method returns a boolean indicating whether the conversion was successful or not.
// TryParse() method is preferred over Parse() method because it does not throw an exception if the conversion fails.

// Parse() method
string input1 = "123";
int number1 = int.Parse(input1); // ❌ Throws FormatException (crashes the program)
Console.WriteLine(number1);

// TryParse() method
string input2 = "abc"; // Invalid input
// TryParse() method returns a boolean indicating whether the conversion was successful or not
// If the conversion is successful, the converted number is stored in the out parameter
// If the conversion fails, the out parameter is set to 0
bool success = int.TryParse(input2, out int number2);

if (success)
    Console.WriteLine($"Conversion successful: {number2}");
else
    Console.WriteLine("Invalid input! Please enter a number.");  // ✅ No crash!