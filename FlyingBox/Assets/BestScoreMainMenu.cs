using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestScoreMainMenu : MonoBehaviour
{

    private Score _score;
    public Text BestScoreText;

    void Start()
    {
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        BestScoreText.text = string.Empty;
        BestScoreText.text = "BEST SCORE : " + _score.GetHighScore().ToString("D");
    }


}
