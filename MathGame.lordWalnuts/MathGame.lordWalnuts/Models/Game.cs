﻿namespace MathGame.lordWalnuts.Models;
internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
    public Difficulty Difficulty { get; set; }
    public string Duration { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}

internal enum Difficulty
{
    Easy,
    Medium,
    Hard
}