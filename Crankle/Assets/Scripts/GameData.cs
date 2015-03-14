public static class GameData
{
    public static float Speed { get; set; }
    public static float DistanceBetweenBorders { get; set; }
    public static float BorderPositionDifference { get; set; }

}

public enum GameStatus { Start, Playing, Pause, GameOver }