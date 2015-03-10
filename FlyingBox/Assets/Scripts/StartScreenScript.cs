using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    static bool _sawOnce;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        if (!_sawOnce)
        {
            _spriteRenderer.enabled = true;
            Time.timeScale = 0;
        }
        _sawOnce = true;
    }

    void Update()
    {
        if (Time.timeScale == 0f && Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            _spriteRenderer.enabled = true;
        }
    }
}
