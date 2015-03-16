using UnityEngine;

public class TailController : MonoBehaviour
{
    public GameObject TailPart;
    private float _lastCreateTime;

    void Start()
    {
        _lastCreateTime = Time.time;
    }

    void Update()
    {
        if (Time.timeScale > 0f && (_lastCreateTime < Time.time - GameData.PeriodBetweenTailParts))
        {
            var tailPart = (GameObject)Instantiate(TailPart, transform.position, Quaternion.identity);
            tailPart.GetComponent<Rigidbody2D>().velocity = Vector2.right * -GameData.Speed;
            tailPart.transform.parent = transform.parent;
            _lastCreateTime = Time.time;
        }
    }
}
