string[] weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

Console.WriteLine("Today is: " + weekDays[1]);
Console.WriteLine("Length of weekdays arrays is: " + weekDays.Length);

////Loop through the array
//for (int i = 0; i < weekDays.Length; i++)
//{
//    Console.WriteLine(weekDays[i]);
//}

foreach (string asd in weekDays)
{
    Console.WriteLine(asd);
}