using UnityEngine;
using Zenject;

public class EatingState : MonoBehaviour
{
    [Inject] private ZombieAnimator _animator;

    private void Start()
    {
        _animator.Eat();
    }
}
