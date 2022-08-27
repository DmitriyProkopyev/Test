using UnityEngine;

public class ZombieAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    private static readonly int Speed = Animator.StringToHash(nameof(Speed));
    private static readonly int Movement = Animator.StringToHash(nameof(Movement));

    public void Idle() => _animator.SetFloat(Speed, 0);

    public void Run() => _animator.SetFloat(Speed, 1);
}
