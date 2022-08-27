using System.Collections;
using Lib;
using UnityEngine;
using Zenject;

public class ZombieSleepingTransition : SimpleTransition
{
    private ZombieSettings _settings;

    [Inject]
    public void Construct(ZombieSettings settings) => _settings = settings;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(_settings.EatingDelay);
        Transit();
    }
}
