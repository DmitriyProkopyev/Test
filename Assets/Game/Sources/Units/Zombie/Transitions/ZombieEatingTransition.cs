using System;
using Game.Sources;
using Lib;
using UnityEngine;

[RequireComponent(typeof(TriggerObserver))]
public class ZombieEatingTransition : ComplexTransition<Human>
{
    private TriggerObserver _observer;

    private void Start() => _observer = GetComponent<TriggerObserver>();

    private void OnEnable() => _observer.Attached += OnAttached;

    private void OnDisable() => _observer.Attached -= OnAttached;

    private void OnAttached(Collider collider)
    {
        if (collider.TryGetComponent(out Human human))
            Transit(human);
    }
}
