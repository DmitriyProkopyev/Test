using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Zombie Settings", fileName = "Zombie Settings", order = 51)]
public class ZombieSettings : ScriptableObject
{
    [field: SerializeField] public float EatingDelay { get; private set; }
}
