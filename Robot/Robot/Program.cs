using System;

// The Robot class is a blueprint that describes what a robot has (properties)
// and what a robot can do (methods).
public class Robot
{
    // Property that stores the name of the robot
    public string Name { get; set; }

    // Property that stores the battery level of the robot
    public int BatteryLevel { get; set; }

    // Method that makes the robot walk. It writes a message to the console
    // saying that the robot is walking.
    public void Walk()
    {
        Console.WriteLine($"{Name} is walking!"); // Prints a message to the console
    }

    // Method that makes the robot talk. It writes a message to the console
    // saying that the robot is talking.
    public void Talk()
    {
        Console.WriteLine($"{Name} says 'Hello!'"); // Prints a message to the console
    }
}

// The Program class contains the main method, where the program starts running.
public class Program
{
    // The Main method is the entry point for the program. 
    public static void Main()
    {
        // Create a new robot object called myRobot using the Robot class
        Robot myRobot = new Robot();

        // Set the Name property of myRobot to "Robo1"
        myRobot.Name = "Robo1";

        // Set the BatteryLevel property of myRobot to 100%
        myRobot.BatteryLevel = 100;

        // Call the Walk method for myRobot, which tells it to walk
        myRobot.Walk();

        // Call the Talk method for myRobot, which tells it to talk
        myRobot.Talk();
    }
}
