using Zenject;

public class Zombie : Unit
{
    private ZombieStateMachine _machine;
    private ZombieLevels _levels;

    [Inject]
    public void Constructor(ZombieStateMachine machine, ZombieLevels levels)
    {
        _levels = levels;
        _machine = machine;
    }

    private int _level;

    public bool ReadyToGo => _level >= _levels.Count;

    private void OnEnable() => _machine.Fed += Upgrade;

    private void OnDisable() => _machine.Fed += Upgrade;

    private void Upgrade()
    {
        _level++;
        var stage = _levels[_level];
    }
}
