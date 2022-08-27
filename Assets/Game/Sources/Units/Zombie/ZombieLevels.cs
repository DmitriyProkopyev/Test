using UnityEngine;

[CreateAssetMenu(menuName = "Zombie Levels", fileName = "Create Zombie Level", order = 51)]
public class ZombieLevels : ScriptableObject
{
    [SerializeField] private Animator[] _levels;

    public Animator this[int index] => _levels[index];

    public int Count => _levels.Length;
}
