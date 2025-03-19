////For Loop
//int i;

//for (i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Count is: {i}");
//}

////For Loop - Count down
//int i2 = 0;

//for (i2 = 5; i2 >= 1; i2--)
//{
//    Console.WriteLine($"Count is: {i2}");
//}

////While Loop - Count up
//int i3 = 0;

//while(i3 <= 5)
//{
//    Console.WriteLine($"Count is: {i3}");
//    i3++;
//}

////While loop - Infinite loop
//bool i4 = true;

//while( i4 )
//{
//    Console.WriteLine("Infinite loop");
//    i4 = false;
//}

//Do While Loop
int i5;

do
{
    Console.WriteLine("Enter a positive number");
    i5 = int.Parse(Console.ReadLine());
} while (i5 <= 0);
Console.WriteLine("Finally!");