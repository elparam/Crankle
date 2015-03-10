using UnityEngine;

public class CameraTracksPlayer : MonoBehaviour
{
    private Transform _playerTransform;
    private float _offsetX;

    void Start()
    {
       _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
       _offsetX = transform.position.x - _playerTransform.position.x;
    }

    void Update()
    {
        if (_playerTransform != null)
        {
            Vector3 pos = transform.position;
            pos.x = _playerTransform.position.x + _offsetX;
            transform.position = pos;
        }
    }
}
