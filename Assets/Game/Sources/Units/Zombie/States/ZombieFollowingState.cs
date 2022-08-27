using Lib;
using Zenject;

public class ZombieFollowingState : SimpleState
{
    private ZombieAnimator _animator;

    [Inject]
    public void Construct(ZombieAnimator animator)
    {
        _animator = animator;
    }
    
    private void Start()
    {
        _animator.Run();
    }
}
