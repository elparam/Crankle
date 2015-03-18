using System.Collections;
using UnityEngine;

public class TailController : MonoBehaviour
{
    public GameObject TailPart;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Time.timeScale > 0f)
        {
            StartCoroutine(CreateTail(transform));
        }
    }

    private IEnumerator CreateTail(Transform transf)
    {
        var tailPart = (GameObject)Instantiate(TailPart, transf.position, Quaternion.identity);
        tailPart.GetComponent<Rigidbody2D>().velocity = - Vector2.right * GameData.Speed;
        tailPart.transform.parent = transf.parent;
        yield return null;
    }
}
