using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lib
{
    public abstract class State : MonoBehaviour
    {
        [SerializeField] private List<Transition> _transitions;

        public event UnityAction<State> Changed;

        private void OnEnable()
        {
            foreach (var transition in _transitions)
            {
                transition.enabled = true;
                transition.Triggered += Exit;
            }
        }

        private void OnDisable() => Exit(default);

        protected void Exit(State next)
        {
            foreach (var transition in _transitions)
            {
                transition.Triggered -= Exit;
                transition.enabled = false;
            }

            enabled = false;
            Changed?.Invoke(next);
        }

        public abstract void Initialize();
    }
}
