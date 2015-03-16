using UnityEngine;

public static class GameData
{
    public static float Speed { get; set; }
    public static float DistanceBetweenBorders { get; set; }
    public static float BorderPositionDifference { get; set; }
    public static float PlayTime { get; set; }
    public static float CurrentScore { get; set; }
    public static float PeriodBetweenTailParts { get; set; }

    public static void ResetData()
    {
        _status = GameStatus.Start;
        CurrentScore = 0;
        StopGame();
    }

    private static GameStatus _status = GameStatus.Start;
    public static GameStatus Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public static void StopGame()
    {
        Time.timeScale = 0;
    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }
}

public enum GameStatus { Start, Playing, Pause, GameOver }