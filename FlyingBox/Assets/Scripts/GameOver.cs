using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text GameOverText;

    private Score _score;
    private Animator _animator;
    private Movement _movement;

    void Start()
    {
        GameOverText.text = string.Empty;
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        _movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        _animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (_movement.Dead)
        {
            GameOverText.text = "SCORE" + "\n" + _score.GetScore().ToString("D") + "\n" + "BEST SCORE" + "\n" + _score.GetHighScore().ToString("D");
            _animator.SetTrigger("GameOver");
        }
    }
}
