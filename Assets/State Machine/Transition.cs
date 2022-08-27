using UnityEngine;
using UnityEngine.Events;

namespace Lib
{
    public abstract class Transition : MonoBehaviour
    {
        public event UnityAction<State> Triggered;

        protected void Trigger(State state) => Triggered?.Invoke(state);
    }
}
