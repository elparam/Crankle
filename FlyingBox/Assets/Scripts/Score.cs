using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    static int score = 0;
    static int highScore = 0;

    static Score instance;


    static public void AddPoint()
    {
        if (instance.player.dead)
            return;

        score++;

        if (score > highScore)
        {
            highScore = score;
                PlayerPrefs.SetInt("highScore", highScore);
        }
    }

    Movement player;

    void Start()
    {

        instance = this;
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        if (player_go == null)
        {
            Debug.LogError("Could not find an object with tag 'Player' ");
        }
        player = player_go.GetComponent<Movement>();
        score = 0;
        highScore = PlayerPrefs.GetInt("highScore", 0);
    }
    void OnDestroy()
    {

        PlayerPrefs.SetInt("highScore", highScore);
        instance = null;        
    }
    void Update()
    {
        guiText.text = score.ToString("D"); ;
        //+ "\n" + "High Score: " + highScore;

    }

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        return highScore;
    }
}

