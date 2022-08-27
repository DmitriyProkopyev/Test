using UnityEngine;

namespace Lib
{
    public abstract class ComplexTransition<T> : Transition
    {
        [SerializeField] private ComplexState<T> _targetState;

        protected void Transit(T value)
        {
            _targetState.Enter(value);
            Trigger(_targetState);
        }
    }
}
