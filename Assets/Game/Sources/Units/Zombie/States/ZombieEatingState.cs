using Lib;
using UnityEngine;
using Zenject;

public class ZombieEatingState : SimpleState
{
    [Inject] private ZombieAnimator _animator;

    private void Start()
    {
        _animator.Eat();
    }
}
