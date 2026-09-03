using System;

class Program
{
    static void Main()
    {
        // 1. Setup variables and welcome messages
        Console.WriteLine("Please type your name.");
        string name = Console.ReadLine();
        DateTime date = DateTime.Now;

        string seperation = "----------------------------------";
        string welcomeMessage = $"Hello {name}! Today's date is: {date}\n";
        string menuMessage = @"What game would you like to play today? Choose from the options below:
1 - Addition
2 - Subtraction
3 - Multiplication
4 - Division
5 - Quit The Program";


        Console.WriteLine(seperation);
        Console.WriteLine(welcomeMessage);
        Console.WriteLine(menuMessage);
        Console.WriteLine(seperation);


        string gameChoice = Console.ReadLine()?.ToUpper();


        switch (gameChoice)
        {
            case "1":
                PlayAddition("Addition Selected.");
                break;
            case "2":
                PlaySubtraction("Subtraction Selected.");
                break;
            case "3":
                PlayMultiplication("Multiplication Selected.");
                break;
            case "4":
                PlayDivision("Division Selected.");
                break;
            case "5":
                QuitProgram();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.Clear();
                Main();
                break;
        }
    }

    static void PlayAddition(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
    }

    static void PlaySubtraction(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
    }

    static void PlayMultiplication(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
    }

    static void PlayDivision(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
    }

    static void QuitProgram()
    {
        Console.Clear();
        Console.WriteLine("Quitting the program.");
        Environment.Exit(0);
    }
}
