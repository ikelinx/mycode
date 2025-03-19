Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your characters name");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type (Warrior, Wizard, Archer, Ninja)");
string characterType = Console.ReadLine();

Console.WriteLine($"Welcome {playerName}! You have chosen a {characterType} type of class!");
Console.WriteLine("You find yourself at the forest, do you wish to enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely entered the forest");
}
else
{
    Console.WriteLine("You decided to camp out and wait for daylight");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You went left and found a treasure chest");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You went right and found a monster!");
        Console.WriteLine("Do you wish to fight or run? (Fight/Run)");
        string choice2 = Console.ReadLine();
        if (choice2.ToLower() == "Fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast!");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast also dropped a treasure!");
                    gameContinues = false;
                }
            }
        }
        else
        {
            Console.WriteLine("You ran away and got lost in the forest");
            gameContinues = false;
        }
    }
}