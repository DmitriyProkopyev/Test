using UnityEngine;
using Zenject;

namespace Lib
{
    public abstract class StateMachine : MonoBehaviour
    {
        [Inject] private State _current;

        private void OnEnable()
        {
            _current.Initialize();
            _current.Changed += Change;
        }

        private void OnDisable() => _current.Changed -= Change;

        private void Change(State state)
        {
            _current.Changed -= Change;
            _current = state;
            _current.Changed += Change;
            OnStateChanged(_current);
        }

        protected abstract void OnStateChanged(State next);
    }
}
