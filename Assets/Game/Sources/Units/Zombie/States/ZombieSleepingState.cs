using Lib;
using Zenject;

public class ZombieSleepingState : SimpleState
{
    private ZombieAnimator _animator;
    
    [Inject]
    public void Construct(ZombieAnimator animator)
    {
        _animator = animator;
    }
    
    public override void Initialize() => Start();

    private void Start() => _animator.Sleep();
}
