using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private Score _score;
    public Text GameOverText;
    Animator anim;
    Movement player;

    void Start()
    {
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        GameOverText.text = string.Empty;
        anim = GetComponentInChildren<Animator>();
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        if (player_go == null)
        {
            Debug.LogError("Could not find an object with tag 'Player' ");
        }
        player = player_go.GetComponent<Movement>();
    }

    void Update()
    {
        if (player.dead == true)
        {
            GameOverText.text = "SCORE" + "\n" + _score.GetScore().ToString("D") + "\n" + "BEST SCORE" + "\n" + _score.GetHighScore().ToString("D");
            anim.SetTrigger("GameOver");
        }
    }
}
