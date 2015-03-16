using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public Sprite PressedSprite;

    private Sprite _nonPressedSprite;
    private SpriteRenderer _spriteRenderer;

    private GameObject _game;
    private GameObject _menu;

	void Start ()
	{
	    _spriteRenderer = GetComponent<SpriteRenderer>();
	    _nonPressedSprite = _spriteRenderer.sprite;
	}
	
	void Update () {
	
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


        _menu = GameObject.FindGameObjectWithTag("Menu");
        _game = GameObject.FindGameObjectWithTag("Game");
        _menu.SetActive(false);
        _game.SetActive(true);
    }
}
