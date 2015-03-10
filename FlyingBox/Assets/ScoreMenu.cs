using UnityEngine;

public class ScoreMenu : MonoBehaviour
{
    private Animator _animator;
    private Movement _movement;

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    }

    void Update()
    {
        if (_movement.Dead)
        {
            _animator.SetTrigger("GameOver");
        }
    }
}
