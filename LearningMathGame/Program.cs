using System;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks.Sources;

class Program
{
    static void Main()
    {
        string name = GetName();
        DateTime date = DateTime.Now;

        string seperation = "----------------------------------";
        string welcomeMessage = $"Hello {name}! Today's date is: {date}\n";
        string menuMessage = @"What game would you like to play today? Choose from the options below:
1 - Addition 5 Questions
2 - Subtraction 5 Questions
3 - Multiplication 5 Questions
4 - Division 5 Questions
5 - Quit The Program";

        Menu(seperation, welcomeMessage, menuMessage);

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

    static void Menu(string seperation, string welcomeMessage, string menuMessage)
    {
        Console.Clear();
        Console.WriteLine(seperation);
        Console.WriteLine(welcomeMessage);
        Console.WriteLine(menuMessage);
        Console.WriteLine(seperation);
    }

    static string GetName()
    {
        Console.WriteLine("Please type your name.");
        var name = Console.ReadLine();
        return name;
    }

    static void PlayAddition(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} + {secondNumber}?");

            var userAnswer = Console.ReadLine();

            if (int.Parse(userAnswer) == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                score++;
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }
            else
            {
                Console.WriteLine("Wrong, Try again!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your score is: {score}/5");
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        Main();
    }

    static void PlaySubtraction(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} - {secondNumber}?");

            var userAnswer = Console.ReadLine();

            if (int.Parse(userAnswer) == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                score++;
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }
            else
            {
                Console.WriteLine("Wrong, Try again!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your score is: {score}/5");
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        Main();
    }

    static void PlayMultiplication(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} * {secondNumber}?");

            var userAnswer = Console.ReadLine();

            if (int.Parse(userAnswer) == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                score++;
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }
            else
            {
                Console.WriteLine("Wrong, Try again!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your score is: {score}/5");
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        Main();
    }

    static void PlayDivision(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} / {secondNumber}?");

            var userAnswer = Console.ReadLine();

            if (int.Parse(userAnswer) == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                score++;
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }
            else
            {
                Console.WriteLine("Wrong, Try again!");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
                totalQuestions--;
                Console.WriteLine($"Questions remaining: {totalQuestions}");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your score is: {score}/5");
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        Main();
    }

    static void QuitProgram()
    {
        Console.Clear();
        Console.WriteLine("Quitting the program.");
        Environment.Exit(0);
    }
}