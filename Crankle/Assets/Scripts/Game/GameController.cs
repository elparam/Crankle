using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Speed;
    public float DistanceBetweenBorders;
    public float BorderPositionDifference;
    public float PeriodBetweenTailParts;
    private float _playedTime;

	void Start ()
	{
	    GameData.Speed = Speed;
        GameData.DistanceBetweenBorders = DistanceBetweenBorders;
        GameData.BorderPositionDifference = BorderPositionDifference;
	    GameData.PeriodBetweenTailParts = PeriodBetweenTailParts;
        GameData.ResetData();
	}
	
	void Update () 
    {
	    if (GameData.Status == GameStatus.Playing)
	    {
	        GameData.PlayTime += Time.deltaTime;
	    }
	}
}
