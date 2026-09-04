using System;
using System.Threading;

namespace LearningMathGame
{
    internal class GameEngine
    {
        internal static void PlayAddition(string message)
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

            Helpers.AddGame(score, Models.GameType.Addition);
            Console.WriteLine($"Game over. Your score is: {score}/5");
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        internal static void PlaySubtraction(string message)
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

            Helpers.AddGame(score, Models.GameType.Subtraction);
            Console.WriteLine($"Game over. Your score is: {score}/5");
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        internal static void PlayMultiplication(string message)
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

            Helpers.AddGame(score, Models.GameType.Multiplication);
            Console.WriteLine($"Game over. Your score is: {score}/5");
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        internal static void PlayDivision(string message)
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

            Helpers.AddGame(score, Models.GameType.Division);
            Console.WriteLine($"Game over. Your score is: {score}/5");
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        internal static void QuitProgram()
        {
            Console.Clear();
            Console.WriteLine("Quitting the program.");
            Environment.Exit(0);
        }

        internal static int[] GetDivisionNumbers()
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
    }
}