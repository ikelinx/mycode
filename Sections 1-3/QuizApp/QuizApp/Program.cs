string question1 = "Who is the 'Golden Maknae' in BTS?";
string answer1a = "jungkook";
string answer1b = "jk";

string question2 = "Which BTS member sings 'Slow Dance'?";
string answer2 = "jimin";

string question3 = "What is the name of V's (Taehyung) Solo album?";
string answer3 = "layover";

int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();
if (userAnswer == answer1a || userAnswer == answer1b)
{
    score++;
    Console.WriteLine($"Correct! You score a point!, your score is now {score}");
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1a + "or: " + answer1b);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim() == answer2)
{
    score++;
    Console.WriteLine($"Correct! You score a point!, your score is now {score}");
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer2);
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3)
{
    score++;
    Console.WriteLine($"Correct! You score a point!, your score is now {score}");
}

else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer3);
}

Console.WriteLine($"Quiz Completed! Your final score is {score}/3");

if (score < 3)
{
    Console.WriteLine("You couldn't score them all, try again");
}
else
{
    Console.WriteLine("You got them all right! Congratulations!");
}

Console.ReadKey();