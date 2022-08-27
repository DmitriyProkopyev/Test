using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Zombie : Unit
{
    [SerializeField] private Animator _animator;
    
    private ZombieStateMachine _machine;
    private ZombieLevels _levels;
    
    private int _level;
    private ZombieSettings _setinngs;

    [Inject]
    public void Constructor(ZombieStateMachine machine, ZombieLevels levels, ZombieSettings settings)
    {
        _levels = levels;
        _machine = machine;
        _setinngs = settings;
    }
    
    public bool ReadyToGo => _level >= _levels.Count;

    private void OnEnable() => _machine.Fed += Upgrade;

    private void OnDisable() => _machine.Fed += Upgrade;

    private void Upgrade()
    {
        _level++;
        StartCoroutine(UpgradeModel());
    }

    private IEnumerator UpgradeModel()
    {
        yield return new WaitForSeconds(_setinngs.EatingDelay);
        Destroy(_animator.gameObject);
        _animator = Instantiate(_levels[_level], transform);
    }
}
