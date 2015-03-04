using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //Vector3 velocity = Vector3.zero;
    public float flapSpeed = 100f;
    public float forwardSpeed = 1f;

    bool didFlap = false;

    Animator animator;

    public bool dead = false;
    float deathCoolDown;

    public bool godMode = false;

    private Vector2 MoveUp = new Vector2(1, 1);
    private Vector2 MoveDown = new Vector2(1, - 1);
    private Vector2 moveVector = Vector2.zero;
	// Use this for initialization
	void Start () {
        animator = GetComponentInChildren<Animator>();
	}
	
    // Do graphics & input updates here
    void Update()
    {
       if(dead)
       {
           deathCoolDown -= Time.deltaTime;

           if(deathCoolDown <= 0)
           {
               if (Input.GetMouseButtonDown(0))
               {
                   Application.LoadLevel(Application.loadedLevel);
               }
           }
       }
       else
       {
           if (Input.GetMouseButtonDown(0))
           {
               didFlap = true;
           }
           rigidbody2D.velocity = moveVector;
       }
    }

	// Do physics engine updates here
    void FixedUpdate()
    {
        //FlyLikeFlappy();
        MoveLikeRustamNeed();        
    }


    private void MoveLikeRustamNeed()
    {
        if (dead)
        { return; }

        if (didFlap)
        {
            if (moveVector == Vector2.zero)
            {
                moveVector = MoveUp;
            } else if(moveVector == MoveUp)
            {
                moveVector = MoveDown;
            }
            else if (moveVector == MoveDown)
            {
                moveVector = MoveUp;
            }            
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode)
            return;

        animator.SetTrigger("Death");
        dead = true;

        deathCoolDown = 0.5f;
	}
}
