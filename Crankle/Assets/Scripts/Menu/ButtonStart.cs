using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public Sprite PressedSprite;

    private Sprite _nonPressedSprite;
    private SpriteRenderer _spriteRenderer;
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _nonPressedSprite = _spriteRenderer.sprite;
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
        HideMenu();
    }

    private void HideMenu()
    {
        var menu = GameObject.FindGameObjectWithTag("Menu");
        if (menu != null)
        {
            var menuAnimator = menu.GetComponent<MenuAnimator>();
            menuAnimator.HideMenu();
        }
    }

    private void ShowMenu()
    {
        var menu = GameObject.FindGameObjectWithTag("Game");
        if (menu != null)
        {
            var gameAnimator = menu.GetComponent<GameAnimator>();
            gameAnimator.ShowGame();
        }
    }
}
