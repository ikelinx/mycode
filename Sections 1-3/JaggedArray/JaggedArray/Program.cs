int[,] numbers = 
    { 
        { 1, 2, 3 }, // row 0
        { 4, 5, 6 }, // row 1
        { 7, 8, 9 }  // row 2
    };

int sumRow0 = numbers[0, 0] + numbers[0, 1] + numbers[0, 2];
int sumRow1 = numbers[1, 0] + numbers[1, 1] + numbers[1, 2];
int sumRow2 = numbers[2, 0] + numbers[2, 1] + numbers[2, 2];

Console.WriteLine(sumRow0);
Console.WriteLine(sumRow1);
Console.WriteLine(sumRow2);
