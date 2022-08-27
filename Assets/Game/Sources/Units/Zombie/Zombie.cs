using Zenject;

public class Zombie : Unit
{
    [Inject] private ZombieStateMachine _machine;

    private int _index;

    private void OnEnable() => _machine.Fed += Upgrade;

    private void OnDisable() => _machine.Fed += Upgrade;

    private void Upgrade()
    {
        _index++;
        //Change Model
    }
}
