using UnityEngine;

public class Movement : MonoBehaviour
{
    public float FlapSpeed = 0.9f;
    public bool Dead;

    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private bool _didFlap;
    private readonly Vector2 _moveUp = new Vector2(1, 1);
    private readonly Vector2 _moveDown = new Vector2(1, -1);
    private Vector2 _moveVector = Vector2.zero;

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!Dead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _didFlap = true;
            }
        }
        _rigidbody2D.velocity = _moveVector * FlapSpeed;
        MoveLikeRustamNeed();
    }

    private void MoveLikeRustamNeed()
    {
        if (!Dead && _didFlap)
        {
            _didFlap = false;
            if (_moveVector == Vector2.zero)
            {
                _moveVector = _moveUp;
            }
            else
            {
                _moveVector = _moveVector == _moveUp ? _moveDown : _moveUp;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.SetTrigger("Death");
        Dead = true;
    }
}
