using UnityEngine;
using System.Collections;

public class GameOverText : MonoBehaviour
{


    Movement player;

    void Start()
    {
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
            guiText.text = "GAME OVER";
        }
    }
}
