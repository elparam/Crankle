﻿using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Speed;
    public float DistanceBetweenBorders;
    public float BorderPositionDifference;
    private float _playedTime;

	void Start ()
	{
	    GameData.Speed = Speed;
        GameData.DistanceBetweenBorders = DistanceBetweenBorders;
        GameData.BorderPositionDifference = BorderPositionDifference;
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
