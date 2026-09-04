using LearningMathGame.Models;
using System;
using System.Collections.Generic;

namespace LearningMathGame
{
    internal class Helpers
    {
        // 1. Capitalized class-level list
        internal static List<Game> Games = new();

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

        // 2. Capitalized method name
        internal void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Game History:");

            // 3. Updated references to use the capital 'Games'
            if (Games == null || Games.Count == 0)
            {
                Console.WriteLine("No games played yet.");
            }
            else
            {
                foreach (var game in Games)
                {
                    Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}");
                }
            }
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
        }

        public static void AddGame(int gameScore, GameType gameType)
        {
            // 4. Updated reference to use the capital 'Games'
            Games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
    }
}