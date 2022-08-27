using System.Collections;
using Lib;
using UnityEngine;
using Zenject;

public class ZombieEatingState : ComplexState<Human>
{
    private ZombieAnimator _animator;
    private ZombieSettings _settings;

    [Inject]
    public void Construct(ZombieAnimator animator, ZombieSettings settings) =>
        (_animator, _settings) = (animator, settings);

    protected override void Setup(Human human)
    {
        _animator.Eat();
        StartCoroutine(Eat(human));
    }

    private IEnumerator Eat(Human human)
    {
        yield return new WaitForSeconds(_settings.EatingDelay);
        Destroy(human);
    }
}
