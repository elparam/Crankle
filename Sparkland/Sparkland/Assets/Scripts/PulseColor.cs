using UnityEngine;

public class PulseColor : MonoBehaviour
{
    public Color StartColor = Color.white;
    public Color EndColor = Color.white;
    public float ColorTolerance = 0.1f;
    public float Speed = 5f;

    private SpriteRenderer _spriteRenderer;
    private Color _endColor;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = StartColor;
        _endColor = EndColor;
    }

    private bool IsColorShouldAnimate()
    {
        var dA = Mathf.Abs(_spriteRenderer.color.a - _endColor.a);
        var dB = Mathf.Abs(_spriteRenderer.color.b - _endColor.b);
        var dR = Mathf.Abs(_spriteRenderer.color.r - _endColor.r);
        var dG = Mathf.Abs(_spriteRenderer.color.g - _endColor.g);
        return dA + dG + dB + dR > ColorTolerance;
    }

    void Update()
    {
        if (IsColorShouldAnimate())
        {
            _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _endColor, Time.deltaTime * Speed);
        }
        else
        {
            _endColor = _endColor == EndColor ? StartColor : EndColor;
        }
    }
}
