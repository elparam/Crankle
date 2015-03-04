using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreMenu : MonoBehaviour
{

   
    Animator anim;
    Movement player;

    void Start()
    {

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
            anim.SetTrigger("GameOver");
        }
    }

}
