using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public Sprite PressedSprite;

    private Sprite _nonPressedSprite;
    private SpriteRenderer _spriteRenderer;

    private GameObject _game;
    private GameObject _menu;

   
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _nonPressedSprite = _spriteRenderer.sprite;
        _game = GameObject.FindGameObjectWithTag("Game");
        _menu = GameObject.FindGameObjectWithTag("Menu");
       
    }

    void Update()
    {
    }

    private bool _isClicked = false;

    void OnMouseDown()
    {
        _isClicked = true;
        _spriteRenderer.sprite = PressedSprite;
    }

    void OnMouseUp()
    {
        if (_isClicked)
        {
            _isClicked = false;
            _spriteRenderer.sprite = _nonPressedSprite;
            StartTheGame();
        }
    }

    void StartTheGame()
    {
        _game.transform.position = Vector2.zero;
        _menu.transform.position = Vector2.up * 100; ;
    }
}
