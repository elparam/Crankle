using UnityEngine;
using UnityEngine.UI;

public class BestScoreMainMenu : MonoBehaviour
{
    public Text BestScoreText;
    private Score _score;

    void Start()
    {
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        BestScoreText.text = string.Empty;
        BestScoreText.text = "BEST SCORE : " + _score.GetHighScore().ToString("D");
    }
}
