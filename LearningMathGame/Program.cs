using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static List<string> games = new List<string>();

    public static void Main()
    {
        string name = GetName();
        bool isRunning = true;

        while (isRunning)
        {
            DateTime date = DateTime.Now;
            string gameChoice = ShowMenu(name, date);

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
                    isRunning = false;
                    QuitProgram();
                    break;
                case "6":
                    Getgames();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static string GetName()
    {
        Console.WriteLine("Please type your name.");
        return Console.ReadLine();
    }

    static string ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        string separation = "----------------------------------";
        Console.WriteLine(separation);
        Console.WriteLine($"Hello {name}! Today's date is: {date}\n");
        Console.WriteLine(@"What game would you like to play today? Choose from the options below:
1 - Addition 5 Questions
2 - Subtraction 5 Questions
3 - Multiplication 5 Questions
4 - Division 5 Questions
5 - Quit The Program
6 - View Game History");
        Console.WriteLine(separation);

        return Console.ReadLine()?.Trim();
    }

    static void PlayAddition(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        for (int i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
            var userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int answer) && answer == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            totalQuestions--;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Questions remaining: {totalQuestions}");
        }

        games.Add($"{DateTime.Now}: Addition - Score: {score}/5");
        Console.WriteLine($"Game over. Your score is: {score}/5");
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }

    static void PlaySubtraction(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        for (int i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
            var userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int answer) && answer == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            totalQuestions--;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Questions remaining: {totalQuestions}");
        }

        Console.WriteLine($"Game over. Your score is: {score}/5");
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }

    static void PlayMultiplication(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        var totalQuestions = 5;

        for (int i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
            var userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int answer) && answer == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            totalQuestions--;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Questions remaining: {totalQuestions}");
        }

        Console.WriteLine($"Game over. Your score is: {score}/5");
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }

    static void PlayDivision(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var score = 0;
        var totalQuestions = 5;

        for (int i = 0; i < 5; i++)
        {
            var divisionNumbers = GetDivisionNumbers();
            int firstNumber = divisionNumbers[0];
            int secondNumber = divisionNumbers[1];

            Console.WriteLine($"What is {firstNumber} / {secondNumber}?");
            var userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int answer) && answer == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            totalQuestions--;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Questions remaining: {totalQuestions}");
        }

        Console.WriteLine($"Game over. Your score is: {score}/5");
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }

    static void QuitProgram()
    {
        Console.Clear();
        Console.WriteLine("Quitting the program.");
        Environment.Exit(0);
    }

    static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 9);
        var secondNumber = random.Next(1, 9);

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }

        return new int[] { firstNumber, secondNumber };
    }

    static void Getgames()
    {
        Console.Clear();
        Console.WriteLine("Game History:");
        if (games.Count == 0)
        {
            Console.WriteLine("No games played yet.");
        }
        else
        {
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }
}