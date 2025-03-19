// Methods

// Creating the method
void WriteSomething() 
{
    Console.WriteLine("I'm Writing something!");
}
// Calling a method
WriteSomething();

//A method that has the parameter asd of type String
void WriteSomethingSpecific(string asd) 
{
    Console.WriteLine("You passed this argument to me " + asd);
}

string myName = "Kyle";

WriteSomethingSpecific(myName);