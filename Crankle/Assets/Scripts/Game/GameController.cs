using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Speed;
    public float DistanceBetweenBorders;
    public float BorderPositionDifference;
    public float PeriodBetweenTailParts;
    private float _playedTime;

    private PlayerController _playerController;

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

    void OnMouseDown()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _playerController.ChangeDirection();
    }
}
