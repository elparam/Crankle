
using UnityEngine;


internal class GameAnimator : MonoBehaviour
{
    private Animator _animator;

    public void ShowGame()
    {
        _animator = GetComponent<Animator>();
        if (_animator != null)
        {
            _animator.SetTrigger("Show");
        }
    }

    public void HideGame()
    {
        if (_animator != null)
        {
            _animator.SetTrigger("Hide");
        }
    }
}
