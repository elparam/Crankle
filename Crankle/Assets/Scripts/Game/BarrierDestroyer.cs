using UnityEngine;

public class BarrierDestroyer : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Border"))
        {
            Destroy(other.transform.parent.gameObject);
        }
        else if (other.CompareTag("TailPart"))
        {
            Destroy(other.gameObject);
        }
    }
}
