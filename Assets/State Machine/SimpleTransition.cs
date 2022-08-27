using UnityEngine;

namespace Lib
{
    public class SimpleTransition : Transition
    {
        [SerializeField] private SimpleState _targetState;

        protected void Transit()
        {
            _targetState.Enter();
            Trigger(_targetState);
        }
    }
}
