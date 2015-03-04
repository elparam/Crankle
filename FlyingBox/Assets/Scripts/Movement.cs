using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float flapSpeed = 0.9f;

    bool didFlap = false;
    Animator animator;
    public bool dead = false;
    float deathCoolDown;
    private Vector2 MoveUp = new Vector2(1, 1);
    private Vector2 MoveDown = new Vector2(1, -1);
    private Vector2 moveVector = Vector2.zero;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (dead)
        {
            deathCoolDown -= Time.deltaTime;

            /*if (deathCoolDown <= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Application.LoadLevel(Application.loadedLevel);
                }
            }*/
        }
        else
        {

            if (Input.GetMouseButtonDown(0))
            {
                didFlap = true;
            }
        }
        rigidbody2D.velocity = moveVector * flapSpeed;
    }

    void FixedUpdate()
    {
        MoveLikeRustamNeed();
    }


    private void MoveLikeRustamNeed()
    {
        if (dead)
        { return; }

        if (didFlap)
        {
            didFlap = false;
            if (moveVector == Vector2.zero)
            {
                moveVector = MoveUp;
            }
            else
            {
                moveVector = moveVector == MoveUp ? MoveDown : MoveUp;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Death");
        dead = true;
        deathCoolDown = 0.5f;
    }
}
