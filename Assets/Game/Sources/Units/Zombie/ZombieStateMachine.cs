using System;
using Lib;

public class ZombieStateMachine : StateMachine
{
    public event Action Fed;
    
    protected override void OnStateChanged(State next)
    {
        if (next is EatingState)
            Fed?.Invoke();
    }
}
