using UnityEngine;

public class BarrierDestroyer : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
       Destroy(other.transform.parent.gameObject);
    }
}
