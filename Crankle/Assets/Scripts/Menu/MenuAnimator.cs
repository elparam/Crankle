using UnityEngine;

public class MenuAnimator : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        if (_animator != null)
        {
            _animator.SetTrigger("Show");
        }
    }

    public void HideMenu()
    {
        if (_animator != null) 
        {
            _animator.SetTrigger("Hide");
        }
    }
}