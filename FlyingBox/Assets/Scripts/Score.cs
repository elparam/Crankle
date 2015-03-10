using UnityEngine;

public class Score : MonoBehaviour
{
    private Movement _movement;
    private GUIText _scoreGuiText;

    private static int _score = 0;
    private static int _highScore = 0;
    private static Score _instance;

    void Start()
    {
        _instance = this;
        _movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        _scoreGuiText = GetComponent<GUIText>();
        _score = 0;
        _highScore = PlayerPrefs.GetInt("highScore", 0);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("highScore", _highScore);
        _instance = null;
    }

    void Update()
    {
        _scoreGuiText.text = _score.ToString("D");
    }

    static public void AddPoint()
    {
        if (_instance._movement.Dead) return;

        _score++;

        if (_score > _highScore)
        {
            _highScore = _score;
            PlayerPrefs.SetInt("highScore", _highScore);
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetHighScore()
    {
        _highScore = PlayerPrefs.GetInt("highScore", 0);
        return _highScore;
    }
}

