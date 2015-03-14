using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Score;

    private Rigidbody2D _rigidbody2D;
    private int _direction;
    private bool _isGameOver;
    private float _timeScale = 1;
    
    void Start()
    {
        PauseTheGame();
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void PauseTheGame()
    {
        Time.timeScale = 0;
    }

    void ResumeTheGame()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!_isGameOver && Input.GetMouseButtonUp(0))
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        if (_direction == 0)
        {
            ResumeTheGame();
            transform.Rotate(new Vector3(0, 0, 45f), Space.World);
            _direction = 1;
            MoveBarriers();
        }
        else
        {
            _direction = _direction * -1;
            transform.Rotate(new Vector3(0, 0, _direction * 90), Space.World);
        }

        _rigidbody2D.velocity = Vector2.up * GameData.Speed * _direction;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Border"))
        {
            _isGameOver = true;
            PauseTheGame();
        }
        else
        {
            if (other.CompareTag("PlusScore"))
            {
                Score++;
            }
        }
    }

    private void MoveBarriers()
    {
        var barriers = GameObject.FindGameObjectsWithTag("Barrier");
        foreach (var barrier in barriers)
        {
            barrier.GetComponent<BarrierController>().MoveBarrier();
        }
    }
}
