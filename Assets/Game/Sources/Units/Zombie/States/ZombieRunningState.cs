using System;
using Lib;
using UnityEngine;
using Zenject;

public class ZombieRunningState : SimpleState
{
    [Inject] private ZombieAnimator _animator;

    private void Start()
    {
        _animator.Run();
    }
}
