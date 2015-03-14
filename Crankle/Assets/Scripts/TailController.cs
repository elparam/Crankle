using System;
using UnityEngine;

public class TailController : MonoBehaviour
{
    public GameObject TailPart;

    void Start()
    {
    }

    void Update()
    {
        if (Math.Abs(Time.timeScale) > 0f)
        {
            var tailPart = (GameObject)Instantiate(TailPart, transform.position, Quaternion.identity);
            tailPart.GetComponent<Rigidbody2D>().velocity = Vector2.right * - GameData.Speed;
        }
    }
}
