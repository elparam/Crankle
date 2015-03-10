using UnityEngine;

public class GameOverText : MonoBehaviour
{
    private Movement _movement;

    void Start()
    {
        var playerGameObject = GameObject.FindGameObjectWithTag("Player");
        if (playerGameObject != null)
        {
            _movement = playerGameObject.GetComponent<Movement>();
        }
    }

    void Update()
    {
        if (_movement != null && _movement.Dead)
        {
            if (GetComponent<GUIText>().text != "GAME OVER")
            {
                GetComponent<GUIText>().text = "GAME OVER";
            }
        }
    }
}
