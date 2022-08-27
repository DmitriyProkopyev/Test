namespace Lib
{
    public abstract class ComplexState<T> : State
    {
        public override void Initialize() => Enter(default);

        protected abstract void Setup(T value);

        public void Enter(T value)
        {
            enabled = true;
            Setup(value);
        }
    }
}