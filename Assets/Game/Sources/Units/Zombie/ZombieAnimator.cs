using UnityEngine;

public class ZombieAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    private static readonly int ZombieIdle = Animator.StringToHash(nameof(ZombieIdle));
    private static readonly int ZombieMovement = Animator.StringToHash(nameof(ZombieMovement));
    private static readonly int ZombieEating = Animator.StringToHash(nameof(ZombieEating));
    private static readonly int ZombieSleeping = Animator.StringToHash(nameof(ZombieSleeping));

    public void Idle() => _animator.Play(ZombieIdle);
    
    public void Run() => _animator.Play(ZombieMovement);
    
    public void Eat() => _animator.Play(ZombieEating);
    
    public void Sleep() => _animator.Play(ZombieSleeping);
}
