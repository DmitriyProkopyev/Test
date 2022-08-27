using Lib;
using Zenject;

public class ZombieIdleState : SimpleState
{
    [Inject] private ZombieAnimator _animator;
    
    public override void Initialize() => Start();

    private void Start()
    {
        _animator.Idle();
    }
}
