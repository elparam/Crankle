using UnityEngine;

public class BarrierController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void MoveBarrier()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * - GameData.Speed;
    }

    public void StopBarrier()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
