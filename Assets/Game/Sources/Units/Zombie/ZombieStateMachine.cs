using System;
using Lib;

public class ZombieStateMachine : StateMachine
{
    public event Action Fed;
    
    public bool Available { get; private set; }
    
    protected override void OnStateChanged(State next)
    {
        Available = true;
        
        if (next is ZombieEatingState)
            Fed?.Invoke();
        else if (next is ZombieSleepingState)
            Available = false;
    }
}
