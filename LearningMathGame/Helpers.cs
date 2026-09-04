using LearningMathGame.Models;
using System;
using System.Collections.Generic;

namespace LearningMathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();

        internal static string GetName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Player";
            }
            return name;
        }

        internal void Getgames()
        {
            Console.Clear();
            Console.WriteLine("Game History:");
            if (games == null || games.Count == 0)
            {
                Console.WriteLine("No games played yet.");
            }
            else
            {
                foreach (var game in games)
                {
                    Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}");
                }
            }
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        public static void AddGame(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

    }
}