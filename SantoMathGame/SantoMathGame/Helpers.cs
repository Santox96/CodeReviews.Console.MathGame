﻿using SantoMathGame.Models;
using System.Linq;
namespace SantoMathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Division, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Subtraction, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Addition, Score = 5 },
        };
        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 08, 01)).OrderByDescending ((x=> x.Score));
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-----------------------------------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            result[0] = firstNumber;
            result[1] = secondNumber;
            return result;
        }
        
        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Must type a name. Try again.");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
