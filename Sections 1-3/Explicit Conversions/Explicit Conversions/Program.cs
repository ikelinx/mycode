//bad Explicit Conversion because long is bigger than int
long myLong = 1234567894781459789;
int myInt = (int)myLong;

Console.WriteLine(myInt);

//good Explicit Conversion because Double is bigger than float
double myDouble = 13.1234567890123456;
float myFloat = (float)myDouble;

Console.WriteLine(myDouble);

//questionable Explicit Conversion as 13.5 can fit into int
double myDouble2 = 13.5;
int myInt2 = (int)myDouble2;

Console.WriteLine(myInt2);