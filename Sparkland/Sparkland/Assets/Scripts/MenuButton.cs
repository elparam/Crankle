using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public Sprite PressedSprite;

    private SpriteRenderer _spriteRenderer;
    private Sprite _nonPressedSprite;

	void Start () {
        _spriteRenderer = GetComponent<SpriteRenderer>();
	    _nonPressedSprite = _spriteRenderer.sprite;
	}
	
	void Update () {
	
	}

    void OnMouseDown()
    {
        _spriteRenderer.sprite = PressedSprite;
    }

    void OnMouseUp()
    {
        _spriteRenderer.sprite = _nonPressedSprite;
    }

    void OnMouseUpAsButton()
    {
        
    }
}
