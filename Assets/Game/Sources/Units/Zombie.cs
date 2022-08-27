using UnityEngine;
using Zenject;

public class Zombie : Unit
{
    [Inject] private ZombieStateMachine _machine;
}
