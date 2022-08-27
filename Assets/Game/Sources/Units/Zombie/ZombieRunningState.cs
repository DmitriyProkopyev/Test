using System;
using UnityEngine;
using Zenject;

public class ZombieRunningState : MonoBehaviour
{
    [Inject] private ZombieAnimator _animator;

    private void Start()
    {
        _animator.Run();
    }
}
